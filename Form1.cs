using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private CurrentGuests guests = new CurrentGuests();
        private Guest guest = new Guest();
        private string selectedFolder = "";
        private bool formChanged = false;
        public Form1()
        {
            InitializeComponent();

            guests.Show(this);
        }

        private void lastNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] guestsWhoHaveVisited = Directory.GetFiles(selectedFolder);
            if (Array.Exists(guestsWhoHaveVisited, x => x.ToString().ToLower().Contains(lastNameBox.Text.ToLower())))
            {
                lastNameBox.Items.AddRange(Array.FindAll(guestsWhoHaveVisited, x => x.ToString().ToLower().Contains(lastNameBox.Text.ToLower())));
                guest.OpenFile(lastNameBox.SelectedItem.ToString());
            }
            else
            {
                guest.LastName = this.lastNameBox.Text;
                guest.Name = this.nameBox.Text;
                guest.Company = this.companyComboBox.Text;
                guest.Document = this.document.Text;
                guest.DocumentNumber = this.textBoxNum.Text;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lastNameBox.Text))
            {
                MessageBox.Show("Please fill out the form", "Nothing To Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            if (File.Exists(lastNameBox.Text))
                saveFileDialog1.FileName = lastNameBox.Text + " " + nameBox.Text;
            else
                saveFileDialog1.FileName = lastNameBox.Text;
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
                guest.Save(guest.LastName);
        }
    }
}
