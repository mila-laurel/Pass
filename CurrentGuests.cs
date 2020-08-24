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
            using (Bitmap heading = new Bitmap(Properties.Resources.RTC, 37, 75))
            {
                g.DrawImage(heading, e.MarginBounds.X + 2, e.MarginBounds.Y + 2);
                using (Font font = new Font("TimesNewRoman", 16))
                {
                    g.DrawString("ЦНИИ РТК", font, Brushes.Black, new Point(e.MarginBounds.X + 40, e.MarginBounds.Y + 32));
                }
            }
        }
    }
}
