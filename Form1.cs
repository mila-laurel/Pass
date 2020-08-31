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

        
        private void lastNameBox_SelectedIndexChanged(object sender, EventArgs e)
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
                    note.ToWhom = "Начальнику науно-производственного комплекса А.В. Иванову";
                    break;
                case Adressee.ПавловАИ:
                    note.ToWhom = "Начальнику 186 Управления по безопасности А.И. Павлову";
                    break;
            }
        }

        private void from_SelectedIndexChanged(object sender, EventArgs e)
        {
            Responsible responsible = (Responsible)from.SelectedIndex;
            switch (responsible)
            {
                case Responsible.АксеновИД:
                    note.From = "Заместителя начальника научно-производственного комплекса по специальной техники И.Д. Аксенова";
                    break;
                case Responsible.ИвановАЕ:
                    note.From = "Начальника 532 отдела «Конструирования мехатронных и управляющих систем специального назначения» А.Е. Иванова";
                    break;
                case Responsible.КоротковАЛ:
                    note.From = "Начальника 111 отдале «Специалной техники» А.Л. Короткова";
                    break;
                case Responsible.ПоповДС:
                    note.From = "Начальника 52 Конструкторского бюро электронных систем и приборов Д.С. Попова";
                    break;
                case Responsible.ПрямицынИБ:
                    note.From = "Начальника 531 отдела «Конструирования робототехнических систем» И.Б. Прямицына";
                    break;
                case Responsible.РоговАВ:
                    note.From = "Начальника 53 Конструкторского бюро мехатронных и корпусных изделий А.В. Рогова";
                    break;
                case Responsible.ШмаковОА:
                    note.From = "Заместителя главного конструктора 11 ЦМРТК О.А. Шмакова";
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
            using (Font font14Bold = new Font("Times New Roman", 14, FontStyle.Bold))
            using (Font font14 = new Font("Times New Roman", 14))
            {
                nextLine = new Point(e.MarginBounds.X, e.MarginBounds.Y + 100 + stringSize.Height * 2);
                stringSize = Size.Ceiling(g.MeasureString("Кому", font14Bold));
                g.DrawString("Кому:", font14Bold, Brushes.Black, nextLine);
                g.DrawString(note.ToWhom, font14, Brushes.Black, nextLine.X + 100, nextLine.Y);
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 5);
                g.DrawString("От:", font14Bold, Brushes.Black, nextLine);
                g.DrawString(note.From, font14, Brushes.Black, nextLine.X + 100, nextLine.Y);
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 5);
                g.DrawString("Дата:", font14Bold, Brushes.Black, nextLine);
                g.DrawString(DateTime.Now.ToString("dd.MM.yyyy"), font14, Brushes.Black, nextLine.X + 100, nextLine.Y);
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 5);
                g.DrawString("Заголовок:", font14Bold, Brushes.Black, nextLine);
                g.DrawString("О выдаче разовых пропусков", font14, Brushes.Black, nextLine.X + 100, nextLine.Y);
                nextLine = new Point(nextLine.X, nextLine.Y + stringSize.Height + 5);
            }
            g.DrawLine(Pens.Black, nextLine, new Point(e.MarginBounds.Right, nextLine.Y));
        }

        private void printPassButton_Click(object sender, EventArgs e)
        {

        }
    }
}
