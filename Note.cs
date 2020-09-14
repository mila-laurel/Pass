using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass
{
    class Note
    {
        public string ToWhom { get; set; }
        public string[] From { get; set; }
        public string Appeal { get; set; }
        public string Allowance { get; set; }
        public string Reason { get; set; }
        public string[] WhereToWhom { get; set; }
        public string Escort { get; set; }
        public Note()
        {
            Allowance = "проход";
            Reason = "в совещании";
        }

        public int PrintTableColumn(Graphics printGraphics, int tableX, int lineY, string[] content)
        {
            Font font12 = new Font("Times New Roman", 12);
            Size stringSize;
            lineY += 2;
            for (int i = 0; i < content.Length; i++)
            {
                stringSize = Size.Ceiling(printGraphics.MeasureString(content[i], font12));
                printGraphics.DrawString(content[i], font12, Brushes.Black, tableX + 2, lineY);
                lineY += (int)stringSize.Height + 2;
            }
            font12.Dispose();
            return lineY;
        }

        public void PrintVerticalLines(Graphics graphics, List<int> columnWidth, int initialY, int maxTableY)
        {
            foreach (int width in columnWidth)
            {
                graphics.DrawLine(Pens.Black, width + 4, initialY, width + 4, maxTableY);
            }
        }

        public void PrintGuestInformation(Graphics graphics, List<Guest> guests, string[] datesOfVisit, Point nextLine, List<int> columnWidth, int margin)
        {
            foreach (Guest guest in guests)
            {
                List<int> tableY = new List<int>();
                tableY.Add(PrintTableColumn(graphics, nextLine.X, nextLine.Y, datesOfVisit));
                tableY.Add(PrintTableColumn(graphics, columnWidth[0] + margin, tableY[0], new string[] { guest.LastName, guest.Name, guest.Patronymic }));
                tableY.Add(PrintTableColumn(graphics, columnWidth[1] + margin, tableY[1], WhereToWhom));
                tableY.Add(PrintTableColumn(graphics, columnWidth[2] + margin, tableY[2], BreakLine(graphics, guest.Company, columnWidth[3]).ToArray()));
                List<string> documentsInfo = BreakLine(graphics, guest.Document, columnWidth[4]);
                documentsInfo.AddRange(BreakLine(graphics, guest.DocumentNumber, columnWidth[4]));
                tableY.Add(PrintTableColumn(graphics, columnWidth[3] + margin, tableY[3], documentsInfo.ToArray()));
                tableY.Add(PrintTableColumn(graphics, columnWidth[4] + margin, tableY[4], BreakLine(graphics, guest.CarInformation, columnWidth[5]).ToArray()));
                tableY.Add(PrintTableColumn(graphics, columnWidth[5] + margin, tableY[5], Escort.Split(' ')));
                PrintVerticalLines(graphics, columnWidth, nextLine.Y, tableY.Max());
            }
        }

        private List<string> BreakLine(Graphics g, string content, int columnWidth)
        {
            int stringSize = (int)g.MeasureString(content, new Font("Times New Roman", 12)).Width;
            List<string> splitedContent = new List<string>();
            if (stringSize > columnWidth)
            {
                int i = 0;
                while (i < content.Length)
                {
                    int indexOfSplit = i+1;
                    while ((int)g.MeasureString(content.Substring(i, indexOfSplit), new Font("Times New Roman", 12)).Width < columnWidth && indexOfSplit<content.Length)
                        indexOfSplit++;
                    splitedContent.Add(content.Substring(i, indexOfSplit));
                    i = indexOfSplit;
                }
            }
            else
                splitedContent.Add(content);
           return splitedContent;
        }
    }
}
