namespace ITDevelopment_Project
{
    partial class FormCustoms
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
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.listViewCustoms = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIOClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompanyClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelAttendance = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameAttendance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDeadLine = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxAttendance = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDead = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(3, 177);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(130, 21);
            this.comboBoxDepartment.TabIndex = 67;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepartment.Location = new System.Drawing.Point(0, 158);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(45, 15);
            this.labelDepartment.TabIndex = 66;
            this.labelDepartment.Text = "Отдел:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ITDevelopment_Project.Properties.Resources._1485088570logo1_big;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(981, 103);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 65;
            this.pictureBoxLogo.TabStop = false;
            // 
            // listViewCustoms
            // 
            this.listViewCustoms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FIOClient,
            this.CompanyClient,
            this.NumberClient,
            this.Department,
            this.NameAttendance,
            this.DateEnd,
            this.Status});
            this.listViewCustoms.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewCustoms.FullRowSelect = true;
            this.listViewCustoms.GridLines = true;
            this.listViewCustoms.HideSelection = false;
            this.listViewCustoms.Location = new System.Drawing.Point(152, 135);
            this.listViewCustoms.Name = "listViewCustoms";
            this.listViewCustoms.Size = new System.Drawing.Size(832, 144);
            this.listViewCustoms.TabIndex = 64;
            this.listViewCustoms.UseCompatibleStateImageBehavior = false;
            this.listViewCustoms.View = System.Windows.Forms.View.Details;
            this.listViewCustoms.SelectedIndexChanged += new System.EventHandler(this.listViewCustoms_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // FIOClient
            // 
            this.FIOClient.Text = "ФИО Клиента";
            this.FIOClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FIOClient.Width = 131;
            // 
            // CompanyClient
            // 
            this.CompanyClient.Text = "Компания клиента";
            this.CompanyClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CompanyClient.Width = 155;
            // 
            // NumberClient
            // 
            this.NumberClient.Text = "Телефон клиента";
            this.NumberClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberClient.Width = 116;
            // 
            // labelAttendance
            // 
            this.labelAttendance.AutoSize = true;
            this.labelAttendance.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttendance.Location = new System.Drawing.Point(0, 200);
            this.labelAttendance.Name = "labelAttendance";
            this.labelAttendance.Size = new System.Drawing.Size(50, 15);
            this.labelAttendance.TabIndex = 60;
            this.labelAttendance.Text = "Услуга:";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(0, 118);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(52, 15);
            this.labelClient.TabIndex = 58;
            this.labelClient.Text = "Клиент:";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(862, 285);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(122, 48);
            this.buttonDel.TabIndex = 57;
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
            this.buttonEdit.Location = new System.Drawing.Point(734, 285);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(122, 48);
            this.buttonEdit.TabIndex = 56;
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
            this.buttonAdd.Location = new System.Drawing.Point(606, 285);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 48);
            this.buttonAdd.TabIndex = 55;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Department
            // 
            this.Department.Text = "Отдел";
            this.Department.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Department.Width = 92;
            // 
            // NameAttendance
            // 
            this.NameAttendance.Text = "Услуга";
            this.NameAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameAttendance.Width = 86;
            // 
            // DateEnd
            // 
            this.DateEnd.Text = "Дата сдачи";
            this.DateEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateEnd.Width = 91;
            // 
            // labelDeadLine
            // 
            this.labelDeadLine.AutoSize = true;
            this.labelDeadLine.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeadLine.Location = new System.Drawing.Point(0, 242);
            this.labelDeadLine.Name = "labelDeadLine";
            this.labelDeadLine.Size = new System.Drawing.Size(63, 15);
            this.labelDeadLine.TabIndex = 68;
            this.labelDeadLine.Text = "Сроки до:";
            this.labelDeadLine.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(3, 303);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(130, 20);
            this.textBoxStatus.TabIndex = 71;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(2, 284);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(73, 15);
            this.labelStatus.TabIndex = 70;
            this.labelStatus.Text = "Состояние:";
            // 
            // Status
            // 
            this.Status.Text = "Состояние";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 94;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(3, 136);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(130, 21);
            this.comboBoxClients.TabIndex = 72;
            // 
            // comboBoxAttendance
            // 
            this.comboBoxAttendance.FormattingEnabled = true;
            this.comboBoxAttendance.Location = new System.Drawing.Point(3, 218);
            this.comboBoxAttendance.Name = "comboBoxAttendance";
            this.comboBoxAttendance.Size = new System.Drawing.Size(130, 21);
            this.comboBoxAttendance.TabIndex = 73;
            // 
            // dateTimePickerDead
            // 
            this.dateTimePickerDead.Location = new System.Drawing.Point(3, 261);
            this.dateTimePickerDead.Name = "dateTimePickerDead";
            this.dateTimePickerDead.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerDead.TabIndex = 74;
            // 
            // FormCustoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 344);
            this.Controls.Add(this.dateTimePickerDead);
            this.Controls.Add(this.comboBoxAttendance);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelDeadLine);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.listViewCustoms);
            this.Controls.Add(this.labelAttendance);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormCustoms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormCustoms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListView listViewCustoms;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FIOClient;
        private System.Windows.Forms.ColumnHeader CompanyClient;
        private System.Windows.Forms.ColumnHeader NumberClient;
        private System.Windows.Forms.Label labelAttendance;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ColumnHeader NameAttendance;
        private System.Windows.Forms.ColumnHeader DateEnd;
        private System.Windows.Forms.Label labelDeadLine;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxAttendance;
        private System.Windows.Forms.DateTimePicker dateTimePickerDead;
    }
}