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
            using (Bitmap heading = new Bitmap(Properties.Resources.RTC, 37, 75))
            {
                g.DrawImage(heading, e.MarginBounds.X, e.MarginBounds.Y);
            }
            using (Font font16 = new Font("TimesNewRoman", 16))
            {
                g.DrawString("ЦНИИ РТК", font16, Brushes.Black, new Point(e.MarginBounds.X + 40, e.MarginBounds.Y + 30));
            }
            using (Font font26 = new Font("TimesNewRoman", 26))
            {
                stringSize = Size.Ceiling(g.MeasureString("СЛУЖЕБНАЯ ЗАПИСКА", font26));
                g.DrawString("СЛУЖЕБНАЯ ЗАПИСКА", font26, Brushes.Black, new Point((e.MarginBounds.Width - stringSize.Width) / 2, e.MarginBounds.Y + 100));
            }.
            using (Font font14Bold = new Font("TimesNewRoman", 14, FontStyle.Bold))
            {
                g.DrawString("Кому", font14Bold, Brushes.Black, new Point((e.MarginBounds.Width - stringSize.Width) / 2, e.MarginBounds.Y + 100));
                
            }

        }
    }
}
