using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass
{
    public class Note
    {
        public string ToWhom { get; set; }
        public string From { get; set; }
        public string Appeal { get; set; }
        public string Allowance { get; set; }
        public string Reason { get; set; }

        public Note()
        {
            Allowance = "проход";
            Reason = "совещании";
        }

        public int PrintTableRow(Graphics printGraphics, int firstColumnX, int tableWidth, int tableY, string[] content)
        {
            Font font12 = new Font("Times New Roman", 12);
            Size stringSize = Size.Ceiling(printGraphics.MeasureString("Дата", font12));
            tableY += 2;
            foreach (string c in content)
            {
                stringSize = Size.Ceiling(printGraphics.MeasureString(c, font12));
                printGraphics.DrawString(c, font12, Brushes.Black, firstColumnX + 2, tableY);
                tableY += (int)stringSize.Height + 2;
            }
            printGraphics.DrawLine(Pens.Black, firstColumnX, tableY, firstColumnX + tableWidth, tableY);
            font12.Dispose();
            return tableY;
        }

        public int PrintTableColumn(Graphics printGraphics, int tableY, int tableWidth, int firstColumnX, int tableX)
        {
            return tableX;
        }
    }
}
