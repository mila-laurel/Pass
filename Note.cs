﻿using System;
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
        public string[] From { get; set; }
        public string Appeal { get; set; }
        public string Allowance { get; set; }
        public string Reason { get; set; }
        
        public Note()
        {
            Allowance = "проход";
            Reason = "в совещании";
        }

        public int PrintTableRow(Graphics printGraphics, int tableX, int tableY, string[] content)
        {
            Font font12 = new Font("Times New Roman", 12);
            Size stringSize;
            tableY += 2;
            foreach (string c in content)
            {
                stringSize = Size.Ceiling(printGraphics.MeasureString(c, font12));
                printGraphics.DrawString(c, font12, Brushes.Black, tableX + 2, tableY);
                tableY += (int)stringSize.Height + 2;
            }
            font12.Dispose();
            return tableY;
        }

        public int PrintTableColumn(Graphics printGraphics, int tableX, int columnWidth, int tableY, string[] content)
        {
            int initialY = tableY;
            Font font12 = new Font("Times New Roman", 12);
            Size stringSize;
            tableY += 2;
            foreach (string c in content)
            {
                stringSize = Size.Ceiling(printGraphics.MeasureString(c, font12));
                printGraphics.DrawString(c, font12, Brushes.Black, tableX + 2, tableY);
                tableY += (int)stringSize.Height + 2;
            }
            font12.Dispose();
            return tableY;
        }
        
        public void PrintVerticalLines(Graphics graphics, List<int> columnWidth, int initialY, int maxTableY)
        {
            foreach (int width in columnWidth)
            {
                graphics.DrawLine(Pens.Black, width + 4, initialY, width + 4, maxTableY);
            }
        }
    }
}
