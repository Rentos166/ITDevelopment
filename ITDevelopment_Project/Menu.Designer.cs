namespace ITDevelopment_Project
{
    partial class Menu
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
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenPersonal = new System.Windows.Forms.Button();
            this.buttonOpenDepartment = new System.Windows.Forms.Button();
            this.buttonOpenAttendance = new System.Windows.Forms.Button();
            this.buttonOpenCustom = new System.Windows.Forms.Button();
            this.buttonOpenSeminars = new System.Windows.Forms.Button();
            this.buttonOpenFinance = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.Location = new System.Drawing.Point(12, 161);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenClients.TabIndex = 44;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = true;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenPersonal
            // 
            this.buttonOpenPersonal.Location = new System.Drawing.Point(12, 215);
            this.buttonOpenPersonal.Name = "buttonOpenPersonal";
            this.buttonOpenPersonal.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenPersonal.TabIndex = 45;
            this.buttonOpenPersonal.Text = "Сотрудники";
            this.buttonOpenPersonal.UseVisualStyleBackColor = true;
            this.buttonOpenPersonal.Click += new System.EventHandler(this.buttonOpenPersonal_Click);
            // 
            // buttonOpenDepartment
            // 
            this.buttonOpenDepartment.Location = new System.Drawing.Point(12, 269);
            this.buttonOpenDepartment.Name = "buttonOpenDepartment";
            this.buttonOpenDepartment.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenDepartment.TabIndex = 46;
            this.buttonOpenDepartment.Text = "Отделы";
            this.buttonOpenDepartment.UseVisualStyleBackColor = true;
            this.buttonOpenDepartment.Click += new System.EventHandler(this.buttonOpenDepartment_Click);
            // 
            // buttonOpenAttendance
            // 
            this.buttonOpenAttendance.Location = new System.Drawing.Point(12, 323);
            this.buttonOpenAttendance.Name = "buttonOpenAttendance";
            this.buttonOpenAttendance.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenAttendance.TabIndex = 47;
            this.buttonOpenAttendance.Text = "Услуги";
            this.buttonOpenAttendance.UseVisualStyleBackColor = true;
            this.buttonOpenAttendance.Click += new System.EventHandler(this.buttonOpenAttendance_Click);
            // 
            // buttonOpenCustom
            // 
            this.buttonOpenCustom.Location = new System.Drawing.Point(12, 377);
            this.buttonOpenCustom.Name = "buttonOpenCustom";
            this.buttonOpenCustom.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenCustom.TabIndex = 48;
            this.buttonOpenCustom.Text = "Заказы";
            this.buttonOpenCustom.UseVisualStyleBackColor = true;
            this.buttonOpenCustom.Click += new System.EventHandler(this.buttonOpenCustom_Click);
            // 
            // buttonOpenSeminars
            // 
            this.buttonOpenSeminars.Location = new System.Drawing.Point(12, 431);
            this.buttonOpenSeminars.Name = "buttonOpenSeminars";
            this.buttonOpenSeminars.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenSeminars.TabIndex = 49;
            this.buttonOpenSeminars.Text = "Семинары";
            this.buttonOpenSeminars.UseVisualStyleBackColor = true;
            this.buttonOpenSeminars.Click += new System.EventHandler(this.buttonOpenSeminars_Click);
            // 
            // buttonOpenFinance
            // 
            this.buttonOpenFinance.Location = new System.Drawing.Point(12, 485);
            this.buttonOpenFinance.Name = "buttonOpenFinance";
            this.buttonOpenFinance.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenFinance.TabIndex = 50;
            this.buttonOpenFinance.Text = "Доходы/расходы";
            this.buttonOpenFinance.UseVisualStyleBackColor = true;
            this.buttonOpenFinance.Click += new System.EventHandler(this.buttonOpenFinance_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Location = new System.Drawing.Point(60, 539);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(158, 48);
            this.buttonExit.TabIndex = 51;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            this.buttonExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonExit_MouseMove);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ITDevelopment_Project.Properties.Resources._1485088570logo1_big;
            this.pictureBoxLogo.Location = new System.Drawing.Point(11, 43);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(254, 112);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 43;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(13, 24);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(53, 13);
            this.labelHello.TabIndex = 52;
            this.labelHello.Text = "Привет :)";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(277, 592);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOpenFinance);
            this.Controls.Add(this.buttonOpenSeminars);
            this.Controls.Add(this.buttonOpenCustom);
            this.Controls.Add(this.buttonOpenAttendance);
            this.Controls.Add(this.buttonOpenDepartment);
            this.Controls.Add(this.buttonOpenPersonal);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItDevelopment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenPersonal;
        private System.Windows.Forms.Button buttonOpenDepartment;
        private System.Windows.Forms.Button buttonOpenAttendance;
        private System.Windows.Forms.Button buttonOpenCustom;
        private System.Windows.Forms.Button buttonOpenSeminars;
        private System.Windows.Forms.Button buttonOpenFinance;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelHello;
    }
}