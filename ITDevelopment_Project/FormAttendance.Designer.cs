namespace ITDevelopment_Project
{
    partial class FormAttendance
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.listViewAttendance = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameAttendance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Guarantee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Departament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxGuarantee = new System.Windows.Forms.TextBox();
            this.labelGuarantee = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxDepartament = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Отдел:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ITDevelopment_Project.Properties.Resources._1485088570logo1_big;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(696, 113);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 52;
            this.pictureBoxLogo.TabStop = false;
            // 
            // listViewAttendance
            // 
            this.listViewAttendance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameAttendance,
            this.Departament,
            this.Price,
            this.Guarantee});
            this.listViewAttendance.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewAttendance.FullRowSelect = true;
            this.listViewAttendance.GridLines = true;
            this.listViewAttendance.HideSelection = false;
            this.listViewAttendance.Location = new System.Drawing.Point(161, 145);
            this.listViewAttendance.Name = "listViewAttendance";
            this.listViewAttendance.Size = new System.Drawing.Size(547, 144);
            this.listViewAttendance.TabIndex = 51;
            this.listViewAttendance.UseCompatibleStateImageBehavior = false;
            this.listViewAttendance.View = System.Windows.Forms.View.Details;
            this.listViewAttendance.SelectedIndexChanged += new System.EventHandler(this.listViewAttendance_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NameAttendance
            // 
            this.NameAttendance.Text = "Название услуги";
            this.NameAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameAttendance.Width = 131;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 116;
            // 
            // Guarantee
            // 
            this.Guarantee.Text = "Гарантия";
            this.Guarantee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Guarantee.Width = 113;
            // 
            // Departament
            // 
            this.Departament.Text = "Отдел";
            this.Departament.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Departament.Width = 121;
            // 
            // textBoxGuarantee
            // 
            this.textBoxGuarantee.Location = new System.Drawing.Point(12, 269);
            this.textBoxGuarantee.Name = "textBoxGuarantee";
            this.textBoxGuarantee.Size = new System.Drawing.Size(130, 20);
            this.textBoxGuarantee.TabIndex = 50;
            // 
            // labelGuarantee
            // 
            this.labelGuarantee.AutoSize = true;
            this.labelGuarantee.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuarantee.Location = new System.Drawing.Point(9, 252);
            this.labelGuarantee.Name = "labelGuarantee";
            this.labelGuarantee.Size = new System.Drawing.Size(64, 15);
            this.labelGuarantee.TabIndex = 49;
            this.labelGuarantee.Text = "Гарантия:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 229);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(130, 20);
            this.textBoxPrice.TabIndex = 48;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(9, 210);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 15);
            this.labelPrice.TabIndex = 47;
            this.labelPrice.Text = "Цена:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 145);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(130, 20);
            this.textBoxName.TabIndex = 40;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(9, 128);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(109, 15);
            this.labelName.TabIndex = 39;
            this.labelName.Text = "Название услуги:";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(586, 295);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(122, 48);
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
            this.buttonEdit.Location = new System.Drawing.Point(458, 295);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(122, 48);
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
            this.buttonAdd.Location = new System.Drawing.Point(330, 295);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 48);
            this.buttonAdd.TabIndex = 36;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxDepartament
            // 
            this.comboBoxDepartament.FormattingEnabled = true;
            this.comboBoxDepartament.Location = new System.Drawing.Point(12, 187);
            this.comboBoxDepartament.Name = "comboBoxDepartament";
            this.comboBoxDepartament.Size = new System.Drawing.Size(130, 21);
            this.comboBoxDepartament.TabIndex = 54;
            // 
            // FormAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 355);
            this.Controls.Add(this.comboBoxDepartament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.listViewAttendance);
            this.Controls.Add(this.textBoxGuarantee);
            this.Controls.Add(this.labelGuarantee);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.FormAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListView listViewAttendance;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameAttendance;
        private System.Windows.Forms.ColumnHeader Departament;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Guarantee;
        private System.Windows.Forms.TextBox textBoxGuarantee;
        private System.Windows.Forms.Label labelGuarantee;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxDepartament;
    }
}