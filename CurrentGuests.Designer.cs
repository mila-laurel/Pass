namespace Pass
{
    partial class CurrentGuests
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentGuests));
            this.tableOfGuests = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.textBoxDocument = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printWord = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tableOfGuests.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableOfGuests
            // 
            this.tableOfGuests.ColumnCount = 4;
            this.tableOfGuests.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.05128F));
            this.tableOfGuests.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.94872F));
            this.tableOfGuests.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableOfGuests.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableOfGuests.Controls.Add(this.label1, 0, 0);
            this.tableOfGuests.Controls.Add(this.textBoxFIO, 0, 1);
            this.tableOfGuests.Controls.Add(this.textBoxCompany, 1, 1);
            this.tableOfGuests.Controls.Add(this.textBoxDocument, 2, 1);
            this.tableOfGuests.Location = new System.Drawing.Point(46, 63);
            this.tableOfGuests.Name = "tableOfGuests";
            this.tableOfGuests.Padding = new System.Windows.Forms.Padding(3);
            this.tableOfGuests.RowCount = 2;
            this.tableOfGuests.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOfGuests.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOfGuests.Size = new System.Drawing.Size(664, 100);
            this.tableOfGuests.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(6, 53);
            this.textBoxFIO.Multiline = true;
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(171, 41);
            this.textBoxFIO.TabIndex = 1;
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(183, 53);
            this.textBoxCompany.Multiline = true;
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(128, 41);
            this.textBoxCompany.TabIndex = 1;
            // 
            // textBoxDocument
            // 
            this.textBoxDocument.Location = new System.Drawing.Point(317, 53);
            this.textBoxDocument.Multiline = true;
            this.textBoxDocument.Name = "textBoxDocument";
            this.textBoxDocument.Size = new System.Drawing.Size(153, 41);
            this.textBoxDocument.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.printWord,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 499);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(765, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printWord
            // 
            this.printWord.Image = ((System.Drawing.Image)(resources.GetObject("printWord.Image")));
            this.printWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printWord.Name = "printWord";
            this.printWord.Size = new System.Drawing.Size(100, 22);
            this.printWord.Text = "&Print Записку";
            this.printWord.Click += new System.EventHandler(this.printWord_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(103, 22);
            this.toolStripButton1.Text = "&Print Пропуск";
            // 
            // CurrentGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 524);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableOfGuests);
            this.Name = "CurrentGuests";
            this.Text = "CurrentGuests";
            this.tableOfGuests.ResumeLayout(false);
            this.tableOfGuests.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableOfGuests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxDocument;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printWord;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}