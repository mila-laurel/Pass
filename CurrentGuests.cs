using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass
{
    public partial class CurrentGuests : Form
    {
        private Note note = new Note();
        public CurrentGuests()
        {
            InitializeComponent();
        }

        private void printWord_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += Document_PrintPage;
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = document;
            preview.ShowDialog(this);
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Size stringSize;
            Point nextLine;
            using (Bitmap heading = new Bitmap(Properties.Resources.RTC, 37, 75))
            {
                g.DrawImage(heading, e.MarginBounds.X + 2, e.MarginBounds.Y);
            }
            using (Font font16 = new Font("Times New Roman", 16))
            {
                g.DrawString("ЦНИИ РТК", font16, Brushes.Black, new Point(e.MarginBounds.X + 40, e.MarginBounds.Y + 30));
            }
            using (Font font26 = new Font("Times New Roman", 26))
            {
                stringSize = Size.Ceiling(g.MeasureString("СЛУЖЕБНАЯ ЗАПИСКА", font26));
                g.DrawString("СЛУЖЕБНАЯ ЗАПИСКА", font26, Brushes.Black, new Point(e.MarginBounds.X + (e.MarginBounds.Width - stringSize.Width) / 2, e.MarginBounds.Y + 100));
            }
            using (Font font14Bold = new Font("Times New Roman", 14, FontStyle.Bold))
            using (Font font14 = new Font("Times New Roman", 14))
            {
                nextLine = new Point(e.MarginBounds.X, e.MarginBounds.Y + 100 + stringSize.Height * 2);
                stringSize = Size.Ceiling(g.MeasureString("Кому", font14Bold));
                g.DrawString("Кому:", font14Bold, Brushes.Black, nextLine);
                g.DrawString(note.Adressee, font14, Brushes.Black, nextLine.X + 100, nextLine.Y);
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 5);
                g.DrawString("От:", font14Bold, Brushes.Black, nextLine);
                g.DrawString(note.Adressee, font14, Brushes.Black, nextLine.X + 100, nextLine.Y);
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 5);
                g.DrawString(note.Adressee, font14, Brushes.Black, nextLine.X + 100, nextLine.Y);
                g.DrawString("Дата:", font14Bold, Brushes.Black, nextLine);
                g.DrawString(DateTime.Now.ToString("dd.MM.yyyy"), font14, Brushes.Black, nextLine.X + 100, nextLine.Y);
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 5);
                g.DrawString("Заголовок:", font14Bold, Brushes.Black, nextLine);
                g.DrawString(note.Adressee, font14, Brushes.Black, nextLine.X + 100, nextLine.Y);
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 5);
            }
            g.DrawLine(Pens.Black, nextLine, new Point(e.MarginBounds.Right, nextLine.Y));
        }
    }
}
