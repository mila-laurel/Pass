namespace Pass
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBoxWater = new System.Windows.Forms.CheckBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toWhom = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.ListBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lastNameBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.patronymBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.document = new System.Windows.Forms.ComboBox();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxCar = new System.Windows.Forms.CheckBox();
            this.carInformation = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printNoteButton = new System.Windows.Forms.ToolStripButton();
            this.printPassButton = new System.Windows.Forms.ToolStripButton();
            this.checkBoxGates = new System.Windows.Forms.CheckBox();
            this.reasonBox = new System.Windows.Forms.ComboBox();
            this.textBoxEscort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxWater
            // 
            this.checkBoxWater.AutoSize = true;
            this.checkBoxWater.Location = new System.Drawing.Point(61, 28);
            this.checkBoxWater.Name = "checkBoxWater";
            this.checkBoxWater.Size = new System.Drawing.Size(51, 17);
            this.checkBoxWater.TabIndex = 0;
            this.checkBoxWater.Text = "Вода";
            this.checkBoxWater.UseVisualStyleBackColor = true;
            this.checkBoxWater.CheckedChanged += new System.EventHandler(this.checkBoxWater_CheckedChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(61, 92);
            this.dateFrom.MinDate = new System.DateTime(2020, 9, 9, 0, 0, 0, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кому";
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(326, 92);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "С";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "По";
            // 
            // toWhom
            // 
            this.toWhom.AllowDrop = true;
            this.toWhom.FormattingEnabled = true;
            this.toWhom.Items.AddRange(new object[] {
            "ИвановАВ",
            "ПавловАИ"});
            this.toWhom.Location = new System.Drawing.Point(99, 140);
            this.toWhom.Name = "toWhom";
            this.toWhom.Size = new System.Drawing.Size(205, 43);
            this.toWhom.TabIndex = 6;
            this.toWhom.SelectedIndexChanged += new System.EventHandler(this.toWhom_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "От";
            // 
            // from
            // 
            this.from.FormattingEnabled = true;
            this.from.Items.AddRange(new object[] {
            "Шмаков Олег Александрович",
            "Рогов Александр Владимирович",
            "Аксенов Иван Дмитриевич",
            "Коротков Алексей Львович",
            "Иванов Андрей Евгеньевич",
            "Прямицын Игорь Борисович",
            "Попов Дмитрий Сергеевич"});
            this.from.Location = new System.Drawing.Point(99, 203);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(205, 95);
            this.from.TabIndex = 8;
            this.from.SelectedIndexChanged += new System.EventHandler(this.from_SelectedIndexChanged_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(329, 203);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(46, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "И.о.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // lastNameBox
            // 
            this.lastNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.lastNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.lastNameBox.FormattingEnabled = true;
            this.lastNameBox.Location = new System.Drawing.Point(99, 317);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(205, 21);
            this.lastNameBox.TabIndex = 10;
            this.lastNameBox.TextChanged += new System.EventHandler(this.lastNameBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ф";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "И";
            // 
            // nameBox
            // 
            this.nameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.nameBox.Location = new System.Drawing.Point(99, 365);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 13;
            // 
            // patronymBox
            // 
            this.patronymBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patronymBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.patronymBox.Location = new System.Drawing.Point(99, 412);
            this.patronymBox.Name = "patronymBox";
            this.patronymBox.Size = new System.Drawing.Size(100, 20);
            this.patronymBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "О";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Цель";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Организация";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(593, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2020, 8, 24, 9, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(593, 119);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.Value = new System.DateTime(2020, 8, 24, 18, 0, 0, 0);
            // 
            // document
            // 
            this.document.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.document.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.document.FormattingEnabled = true;
            this.document.Items.AddRange(new object[] {
            "Паспорт",
            "Служ. удостоверение",
            "Вод. удостоверение"});
            this.document.Location = new System.Drawing.Point(638, 298);
            this.document.Name = "document";
            this.document.Size = new System.Drawing.Size(121, 21);
            this.document.TabIndex = 23;
            // 
            // companyComboBox
            // 
            this.companyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.companyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(387, 317);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(199, 21);
            this.companyComboBox.TabIndex = 24;
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(638, 326);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(134, 20);
            this.textBoxNum.TabIndex = 25;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonOk.Location = new System.Drawing.Point(387, 383);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(255, 49);
            this.buttonOk.TabIndex = 26;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // checkBoxCar
            // 
            this.checkBoxCar.AutoSize = true;
            this.checkBoxCar.Location = new System.Drawing.Point(61, 499);
            this.checkBoxCar.Name = "checkBoxCar";
            this.checkBoxCar.Size = new System.Drawing.Size(67, 17);
            this.checkBoxCar.TabIndex = 27;
            this.checkBoxCar.Text = "Машина";
            this.checkBoxCar.UseVisualStyleBackColor = true;
            // 
            // carInformation
            // 
            this.carInformation.Location = new System.Drawing.Point(176, 499);
            this.carInformation.Name = "carInformation";
            this.carInformation.Size = new System.Drawing.Size(208, 20);
            this.carInformation.TabIndex = 28;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.printNoteButton,
            this.printPassButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 610);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(915, 25);
            this.toolStrip1.TabIndex = 29;
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
            // printNoteButton
            // 
            this.printNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("printNoteButton.Image")));
            this.printNoteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printNoteButton.Name = "printNoteButton";
            this.printNoteButton.Size = new System.Drawing.Size(100, 22);
            this.printNoteButton.Text = "Print Записку";
            this.printNoteButton.Click += new System.EventHandler(this.printNoteButton_Click);
            // 
            // printPassButton
            // 
            this.printPassButton.Image = ((System.Drawing.Image)(resources.GetObject("printPassButton.Image")));
            this.printPassButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPassButton.Name = "printPassButton";
            this.printPassButton.Size = new System.Drawing.Size(103, 22);
            this.printPassButton.Text = "&Print Пропуск";
            this.printPassButton.Click += new System.EventHandler(this.printPassButton_Click);
            // 
            // checkBoxGates
            // 
            this.checkBoxGates.AutoSize = true;
            this.checkBoxGates.Location = new System.Drawing.Point(426, 499);
            this.checkBoxGates.Name = "checkBoxGates";
            this.checkBoxGates.Size = new System.Drawing.Size(88, 17);
            this.checkBoxGates.TabIndex = 30;
            this.checkBoxGates.Text = "Третий пост";
            this.checkBoxGates.UseVisualStyleBackColor = true;
            this.checkBoxGates.CheckedChanged += new System.EventHandler(this.checkBoxGates_CheckedChanged);
            // 
            // reasonBox
            // 
            this.reasonBox.FormattingEnabled = true;
            this.reasonBox.Location = new System.Drawing.Point(329, 28);
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(463, 21);
            this.reasonBox.TabIndex = 31;
            this.reasonBox.TextChanged += new System.EventHandler(this.reasonBox_TextChanged);
            // 
            // textBoxEscort
            // 
            this.textBoxEscort.Location = new System.Drawing.Point(490, 203);
            this.textBoxEscort.Name = "textBoxEscort";
            this.textBoxEscort.Size = new System.Drawing.Size(163, 20);
            this.textBoxEscort.TabIndex = 32;
            this.textBoxEscort.TextChanged += new System.EventHandler(this.textBoxEscort_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Сопровождающий";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(915, 635);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxEscort);
            this.Controls.Add(this.reasonBox);
            this.Controls.Add(this.checkBoxGates);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.carInformation);
            this.Controls.Add(this.checkBoxCar);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.document);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.patronymBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toWhom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.checkBoxWater);
            this.Name = "Form1";
            this.Text = "Pass Form";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxWater;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox toWhom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox from;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox lastNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox patronymBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox document;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxCar;
        private System.Windows.Forms.TextBox carInformation;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printNoteButton;
        private System.Windows.Forms.ToolStripButton printPassButton;
        private System.Windows.Forms.CheckBox checkBoxGates;
        private System.Windows.Forms.ComboBox reasonBox;
        private System.Windows.Forms.TextBox textBoxEscort;
        private System.Windows.Forms.Label label10;
    }
}

