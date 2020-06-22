namespace ITDevelopment_Project
{
    partial class FormDepartament
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.listViewDepartament = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountPersonal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manager = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxManager = new System.Windows.Forms.TextBox();
            this.labelManager = new System.Windows.Forms.Label();
            this.textBoxNameCompany = new System.Windows.Forms.TextBox();
            this.labelNameCompany = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ITDevelopment_Project.Properties.Resources._1485088570logo1_big;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(686, 113);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 42;
            this.pictureBoxLogo.TabStop = false;
            // 
            // listViewDepartament
            // 
            this.listViewDepartament.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameCompany,
            this.CountPersonal,
            this.Manager});
            this.listViewDepartament.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDepartament.FullRowSelect = true;
            this.listViewDepartament.GridLines = true;
            this.listViewDepartament.HideSelection = false;
            this.listViewDepartament.Location = new System.Drawing.Point(161, 143);
            this.listViewDepartament.Name = "listViewDepartament";
            this.listViewDepartament.Size = new System.Drawing.Size(537, 109);
            this.listViewDepartament.TabIndex = 41;
            this.listViewDepartament.UseCompatibleStateImageBehavior = false;
            this.listViewDepartament.View = System.Windows.Forms.View.Details;
            this.listViewDepartament.SelectedIndexChanged += new System.EventHandler(this.listViewDepartament_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NameCompany
            // 
            this.NameCompany.Text = "Название отдела";
            this.NameCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameCompany.Width = 161;
            // 
            // CountPersonal
            // 
            this.CountPersonal.Text = "Количество сотрудников";
            this.CountPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountPersonal.Width = 170;
            // 
            // Manager
            // 
            this.Manager.Text = "Руководитель";
            this.Manager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Manager.Width = 141;
            // 
            // textBoxManager
            // 
            this.textBoxManager.Location = new System.Drawing.Point(12, 185);
            this.textBoxManager.Name = "textBoxManager";
            this.textBoxManager.Size = new System.Drawing.Size(130, 20);
            this.textBoxManager.TabIndex = 40;
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManager.Location = new System.Drawing.Point(9, 168);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(92, 15);
            this.labelManager.TabIndex = 39;
            this.labelManager.Text = "Руководитель:";
            // 
            // textBoxNameCompany
            // 
            this.textBoxNameCompany.Location = new System.Drawing.Point(12, 145);
            this.textBoxNameCompany.Name = "textBoxNameCompany";
            this.textBoxNameCompany.Size = new System.Drawing.Size(130, 20);
            this.textBoxNameCompany.TabIndex = 38;
            // 
            // labelNameCompany
            // 
            this.labelNameCompany.AutoSize = true;
            this.labelNameCompany.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameCompany.Location = new System.Drawing.Point(9, 128);
            this.labelNameCompany.Name = "labelNameCompany";
            this.labelNameCompany.Size = new System.Drawing.Size(111, 15);
            this.labelNameCompany.TabIndex = 37;
            this.labelNameCompany.Text = "Название отдела:";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(561, 258);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(137, 48);
            this.buttonDel.TabIndex = 36;
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
            this.buttonEdit.Location = new System.Drawing.Point(418, 258);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(137, 48);
            this.buttonEdit.TabIndex = 35;
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
            this.buttonAdd.Location = new System.Drawing.Point(275, 258);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 48);
            this.buttonAdd.TabIndex = 34;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormDepartament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 341);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.listViewDepartament);
            this.Controls.Add(this.textBoxManager);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.textBoxNameCompany);
            this.Controls.Add(this.labelNameCompany);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormDepartament";
            this.Text = "Отделы";
            this.Load += new System.EventHandler(this.FormDepartament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListView listViewDepartament;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameCompany;
        private System.Windows.Forms.ColumnHeader CountPersonal;
        private System.Windows.Forms.ColumnHeader Manager;
        private System.Windows.Forms.TextBox textBoxManager;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.TextBox textBoxNameCompany;
        private System.Windows.Forms.Label labelNameCompany;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
    }
}