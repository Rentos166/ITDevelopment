namespace ITDevelopment_Project
{
    partial class FormSeminars
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
            this.labelDate = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.listViewSeminar = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameSeminar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAddress_House = new System.Windows.Forms.TextBox();
            this.labelAddress_House = new System.Windows.Forms.Label();
            this.textBoxAddress_Street = new System.Windows.Forms.TextBox();
            this.labelAddress_Street = new System.Windows.Forms.Label();
            this.textBoxAddress_City = new System.Windows.Forms.TextBox();
            this.labelAddress_City = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxTypeSeminar = new System.Windows.Forms.ComboBox();
            this.dateTimePickerSeminar = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(9, 289);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(112, 15);
            this.labelDate.TabIndex = 53;
            this.labelDate.Text = "Дата проведения:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ITDevelopment_Project.Properties.Resources._1485088570logo1_big;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(1064, 113);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 52;
            this.pictureBoxLogo.TabStop = false;
            // 
            // listViewSeminar
            // 
            this.listViewSeminar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameSeminar,
            this.Address,
            this.Date});
            this.listViewSeminar.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewSeminar.FullRowSelect = true;
            this.listViewSeminar.GridLines = true;
            this.listViewSeminar.HideSelection = false;
            this.listViewSeminar.Location = new System.Drawing.Point(267, 145);
            this.listViewSeminar.Name = "listViewSeminar";
            this.listViewSeminar.Size = new System.Drawing.Size(809, 196);
            this.listViewSeminar.TabIndex = 51;
            this.listViewSeminar.UseCompatibleStateImageBehavior = false;
            this.listViewSeminar.View = System.Windows.Forms.View.Details;
            this.listViewSeminar.SelectedIndexChanged += new System.EventHandler(this.listViewSeminar_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NameSeminar
            // 
            this.NameSeminar.Text = "Семинар";
            this.NameSeminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameSeminar.Width = 434;
            // 
            // Address
            // 
            this.Address.Text = "Адрес проведения";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 192;
            // 
            // Date
            // 
            this.Date.Text = "Дата проведения:";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 117;
            // 
            // textBoxAddress_House
            // 
            this.textBoxAddress_House.Location = new System.Drawing.Point(12, 265);
            this.textBoxAddress_House.Name = "textBoxAddress_House";
            this.textBoxAddress_House.Size = new System.Drawing.Size(249, 20);
            this.textBoxAddress_House.TabIndex = 46;
            // 
            // labelAddress_House
            // 
            this.labelAddress_House.AutoSize = true;
            this.labelAddress_House.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_House.Location = new System.Drawing.Point(9, 248);
            this.labelAddress_House.Name = "labelAddress_House";
            this.labelAddress_House.Size = new System.Drawing.Size(36, 15);
            this.labelAddress_House.TabIndex = 45;
            this.labelAddress_House.Text = "Дом:";
            // 
            // textBoxAddress_Street
            // 
            this.textBoxAddress_Street.Location = new System.Drawing.Point(12, 225);
            this.textBoxAddress_Street.Name = "textBoxAddress_Street";
            this.textBoxAddress_Street.Size = new System.Drawing.Size(249, 20);
            this.textBoxAddress_Street.TabIndex = 44;
            // 
            // labelAddress_Street
            // 
            this.labelAddress_Street.AutoSize = true;
            this.labelAddress_Street.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_Street.Location = new System.Drawing.Point(9, 208);
            this.labelAddress_Street.Name = "labelAddress_Street";
            this.labelAddress_Street.Size = new System.Drawing.Size(43, 15);
            this.labelAddress_Street.TabIndex = 43;
            this.labelAddress_Street.Text = "Улица";
            // 
            // textBoxAddress_City
            // 
            this.textBoxAddress_City.Location = new System.Drawing.Point(12, 185);
            this.textBoxAddress_City.Name = "textBoxAddress_City";
            this.textBoxAddress_City.Size = new System.Drawing.Size(249, 20);
            this.textBoxAddress_City.TabIndex = 42;
            // 
            // labelAddress_City
            // 
            this.labelAddress_City.AutoSize = true;
            this.labelAddress_City.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress_City.Location = new System.Drawing.Point(9, 168);
            this.labelAddress_City.Name = "labelAddress_City";
            this.labelAddress_City.Size = new System.Drawing.Size(44, 15);
            this.labelAddress_City.TabIndex = 41;
            this.labelAddress_City.Text = "Город:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(9, 128);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(63, 15);
            this.labelFirstName.TabIndex = 39;
            this.labelFirstName.Text = "Семинар:";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(858, 347);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(219, 48);
            this.buttonDel.TabIndex = 38;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(633, 347);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(219, 48);
            this.buttonEdit.TabIndex = 37;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(406, 347);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(219, 48);
            this.buttonAdd.TabIndex = 36;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxTypeSeminar
            // 
            this.comboBoxTypeSeminar.FormattingEnabled = true;
            this.comboBoxTypeSeminar.Items.AddRange(new object[] {
            "Внедрение коммуникационной платформы для управления бизнес-процессами",
            "Приложения для мобильной работы",
            "Внедрение системы автоматизации управления бизнес-процессами"});
            this.comboBoxTypeSeminar.Location = new System.Drawing.Point(12, 145);
            this.comboBoxTypeSeminar.Name = "comboBoxTypeSeminar";
            this.comboBoxTypeSeminar.Size = new System.Drawing.Size(249, 21);
            this.comboBoxTypeSeminar.TabIndex = 55;
            // 
            // dateTimePickerSeminar
            // 
            this.dateTimePickerSeminar.Location = new System.Drawing.Point(13, 307);
            this.dateTimePickerSeminar.Name = "dateTimePickerSeminar";
            this.dateTimePickerSeminar.Size = new System.Drawing.Size(248, 20);
            this.dateTimePickerSeminar.TabIndex = 56;
            // 
            // FormSeminars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 412);
            this.Controls.Add(this.dateTimePickerSeminar);
            this.Controls.Add(this.comboBoxTypeSeminar);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.listViewSeminar);
            this.Controls.Add(this.textBoxAddress_House);
            this.Controls.Add(this.labelAddress_House);
            this.Controls.Add(this.textBoxAddress_Street);
            this.Controls.Add(this.labelAddress_Street);
            this.Controls.Add(this.textBoxAddress_City);
            this.Controls.Add(this.labelAddress_City);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormSeminars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Семинары";
            this.Load += new System.EventHandler(this.FormSeminars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListView listViewSeminar;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameSeminar;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.TextBox textBoxAddress_House;
        private System.Windows.Forms.Label labelAddress_House;
        private System.Windows.Forms.TextBox textBoxAddress_Street;
        private System.Windows.Forms.Label labelAddress_Street;
        private System.Windows.Forms.TextBox textBoxAddress_City;
        private System.Windows.Forms.Label labelAddress_City;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxTypeSeminar;
        private System.Windows.Forms.DateTimePicker dateTimePickerSeminar;
    }
}