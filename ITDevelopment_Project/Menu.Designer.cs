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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.Location = new System.Drawing.Point(5, 119);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenClients.TabIndex = 44;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = true;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenPersonal
            // 
            this.buttonOpenPersonal.Location = new System.Drawing.Point(5, 173);
            this.buttonOpenPersonal.Name = "buttonOpenPersonal";
            this.buttonOpenPersonal.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenPersonal.TabIndex = 45;
            this.buttonOpenPersonal.Text = "Сотрудники";
            this.buttonOpenPersonal.UseVisualStyleBackColor = true;
            this.buttonOpenPersonal.Click += new System.EventHandler(this.buttonOpenPersonal_Click);
            // 
            // buttonOpenDepartment
            // 
            this.buttonOpenDepartment.Location = new System.Drawing.Point(5, 227);
            this.buttonOpenDepartment.Name = "buttonOpenDepartment";
            this.buttonOpenDepartment.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenDepartment.TabIndex = 46;
            this.buttonOpenDepartment.Text = "Отделы";
            this.buttonOpenDepartment.UseVisualStyleBackColor = true;
            this.buttonOpenDepartment.Click += new System.EventHandler(this.buttonOpenDepartment_Click);
            // 
            // buttonOpenAttendance
            // 
            this.buttonOpenAttendance.Location = new System.Drawing.Point(5, 281);
            this.buttonOpenAttendance.Name = "buttonOpenAttendance";
            this.buttonOpenAttendance.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenAttendance.TabIndex = 47;
            this.buttonOpenAttendance.Text = "Услуги";
            this.buttonOpenAttendance.UseVisualStyleBackColor = true;
            this.buttonOpenAttendance.Click += new System.EventHandler(this.buttonOpenAttendance_Click);
            // 
            // buttonOpenCustom
            // 
            this.buttonOpenCustom.Location = new System.Drawing.Point(5, 335);
            this.buttonOpenCustom.Name = "buttonOpenCustom";
            this.buttonOpenCustom.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenCustom.TabIndex = 48;
            this.buttonOpenCustom.Text = "Заказы";
            this.buttonOpenCustom.UseVisualStyleBackColor = true;
            this.buttonOpenCustom.Click += new System.EventHandler(this.buttonOpenCustom_Click);
            // 
            // buttonOpenSeminars
            // 
            this.buttonOpenSeminars.Location = new System.Drawing.Point(5, 389);
            this.buttonOpenSeminars.Name = "buttonOpenSeminars";
            this.buttonOpenSeminars.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenSeminars.TabIndex = 49;
            this.buttonOpenSeminars.Text = "Семинары";
            this.buttonOpenSeminars.UseVisualStyleBackColor = true;
            this.buttonOpenSeminars.Click += new System.EventHandler(this.buttonOpenSeminars_Click);
            // 
            // buttonOpenFinance
            // 
            this.buttonOpenFinance.Location = new System.Drawing.Point(5, 443);
            this.buttonOpenFinance.Name = "buttonOpenFinance";
            this.buttonOpenFinance.Size = new System.Drawing.Size(254, 48);
            this.buttonOpenFinance.TabIndex = 50;
            this.buttonOpenFinance.Text = "Доходы/расходы";
            this.buttonOpenFinance.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ITDevelopment_Project.Properties.Resources._1485088570logo1_big;
            this.pictureBoxLogo.Location = new System.Drawing.Point(5, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(254, 112);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 43;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 497);
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
    }
}