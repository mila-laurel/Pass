using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Pass
{
    public partial class Form1 : Form
    {
        private List<Guest> guests =new List<Guest>();
        private string selectedFolder = @"C:\Users\ЛавроваЛЮ\Documents\пропуска\new";
        
        private Note note;
        public Form1()
        {
            InitializeComponent();
            
            note = new Note();
            
        }

        
        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {
            string[] guestsWhoHaveVisited = Directory.GetFiles(selectedFolder);
            if (Array.Exists(guestsWhoHaveVisited, x => x.ToString().ToLower().Contains(lastNameBox.Text.ToLower())))
            {
                lastNameBox.Items.AddRange(Array.FindAll(guestsWhoHaveVisited, x => x.ToString().ToLower().Contains(lastNameBox.Text.ToLower())));
                Guest guest = new Guest();
                guest.OpenFile(lastNameBox.SelectedItem.ToString());
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lastNameBox.Text))
            {
                MessageBox.Show("Please fill out the form", "Nothing To Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Guest guest = new Guest();
            guest.LastName = this.lastNameBox.Text;
            guest.Name = this.nameBox.Text;
            guest.Company = this.companyComboBox.Text;
            guest.Document = this.document.Text;
            guest.DocumentNumber = this.textBoxNum.Text;
            guests.Add(guest);
            saveFileDialog1.InitialDirectory = selectedFolder;
            if (File.Exists(lastNameBox.Text))
                saveFileDialog1.FileName = lastNameBox.Text + " " + nameBox.Text;
            else
                saveFileDialog1.FileName = lastNameBox.Text;
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
                guest.Save(guest.LastName);
        }

        private void toWhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Adressee adressee = (Adressee)toWhom.SelectedIndex;
            switch (adressee)
            {
                case Adressee.ИвановАВ:
                    note.ToWhom = "Начальнику научно-производственного комплекса А.В. Иванову";
                    note.Appeal = "Уважаемый Александр Владиславович!";
                    break;
                case Adressee.ПавловАИ:
                    note.ToWhom = "Начальнику 186 Управления по безопасности А.И. Павлову";
                    note.Appeal = "Уважаемый Андрей Игоревич!";
                    break;
            }
        }

        private void from_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Responsible responsible = (Responsible)from.SelectedIndex;
            switch (responsible)
            {
                case Responsible.АксеновИД:
                    note.From = new string[] { "Заместителя начальника научно-производственного комплекса", "по специальной техники И.Д. Аксенова"};
                    break;
                case Responsible.ИвановАЕ:
                    note.From = new string[] { "Начальника 532 отдела «Конструирования мехатронных и управляющих", "систем специального назначения» А.Е. Иванова" };
                    break;
                case Responsible.КоротковАЛ:
                    note.From = new string[] { "Начальника 111 отдела «Специальной техники» А.Л. Короткова" };
                    break;
                case Responsible.ПоповДС:
                    note.From = new string[] { "Начальника 52 Конструкторского бюро электронных систем и приборов", "Д.С. Попова" };
                    break;
                case Responsible.ПрямицынИБ:
                    note.From = new string[] { "Начальника 531 отдела «Конструирования робототехнических систем»", "И.Б. Прямицына" };
                    break;
                case Responsible.РоговАВ:
                    note.From = new string[] { "Начальника 53 Конструкторского бюро мехатронных и корпусных изделий", "А.В. Рогова" };
                    break;
                case Responsible.ШмаковОА:
                    note.From = new string[] { "Заместителя главного конструктора 11 ЦМРТК О.А. Шмакова" };
                    break;
            }
        }

        private void printNoteButton_Click(object sender, EventArgs e)
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
            using (Font font12Bold = new Font("Times New Roman", 12, FontStyle.Bold))
            using (Font font12 = new Font("Times New Roman", 12))
            {
                nextLine = new Point(e.MarginBounds.X, e.MarginBounds.Y + 100 + stringSize.Height * 2);
                stringSize = Size.Ceiling(g.MeasureString("Кому", font12Bold));
                g.DrawString("Кому:", font12Bold, Brushes.Black, nextLine);
                g.DrawString(note.ToWhom, font12, Brushes.Black, nextLine.X + 100, nextLine.Y);
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 5);
                g.DrawString("От:", font12Bold, Brushes.Black, nextLine);
                g.DrawString(note.From[0], font12, Brushes.Black, nextLine.X + 100, nextLine.Y);
                if(note.From.Length > 1)
                {
                    nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 2);
                    g.DrawString(note.From[1], font12, Brushes.Black, nextLine.X + 100, nextLine.Y);
                }
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 5);
                g.DrawString("Дата:", font12Bold, Brushes.Black, nextLine);
                g.DrawString(DateTime.Now.ToString("dd.MM.yyyy"), font12, Brushes.Black, nextLine.X + 100, nextLine.Y);
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 5);
                g.DrawString("Заголовок:", font12Bold, Brushes.Black, nextLine);
                g.DrawString("О выдаче разовых пропусков", font12, Brushes.Black, nextLine.X + 100, nextLine.Y);
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 5);
            }
            g.DrawLine(Pens.Black, nextLine, new Point(e.MarginBounds.Right, nextLine.Y));
            nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 10);
            using (Font font14 = new Font("Times New Roman", 14))
            {
                stringSize = Size.Ceiling(g.MeasureString(note.Appeal, font14));
                g.DrawString(note.Appeal, font14, Brushes.Black, new Point(e.MarginBounds.X + (e.MarginBounds.Width - stringSize.Width) / 2, nextLine.Y));
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 6);
                g.DrawString("Прошу разрешить " + note.Allowance + " на территорию ЦНИИ РТК для " + ((checkBoxWater.Checked) ? "доставки": "участия"), font14, Brushes.Black, new Point(e.MarginBounds.X + 48, nextLine.Y));
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 2);
                g.DrawString(note.Reason + ":", font14, Brushes.Black, new Point(e.MarginBounds.X, nextLine.Y));
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 4);
            }
            Point topCornerofTable = new Point(nextLine.X, nextLine.Y);
            int tableX = nextLine.X;
            int tableWidth = e.MarginBounds.Width;
            int tableY = nextLine.Y;
            tableY = note.PrintTableRow(g, tableX, tableWidth, tableY, new string[] { "Дата и", "время", "посещения" });
            g.DrawRectangle(Pens.Black, topCornerofTable.X, topCornerofTable.Y, tableWidth, tableY);
        }

        private void printPassButton_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxGates_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGates.Checked)
                note.Allowance = "въезд";
        }

        private void reasonBox_TextChanged(object sender, EventArgs e)
        {
            if (!checkBoxWater.Checked)
            {
                note.Reason = reasonBox.Text;
                reasonBox.Items.Add(note.Reason);
            }
        }

        private void checkBoxWater_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWater.Checked)
            {
                note.Allowance = "въезд";
                note.Reason = "питьевой воды";
            }
        }
    }
}
