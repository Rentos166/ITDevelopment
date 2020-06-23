namespace ITDevelopment_Project
{
    partial class FormFinance
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
            this.dateTimePickerFinance = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.listViewFinance = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Costs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxCosts = new System.Windows.Forms.TextBox();
            this.labelCosts = new System.Windows.Forms.Label();
            this.textBoxGains = new System.Windows.Forms.TextBox();
            this.labelGains = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.Profit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerFinance
            // 
            this.dateTimePickerFinance.Location = new System.Drawing.Point(12, 122);
            this.dateTimePickerFinance.Name = "dateTimePickerFinance";
            this.dateTimePickerFinance.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerFinance.TabIndex = 66;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(8, 104);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 15);
            this.labelDate.TabIndex = 65;
            this.labelDate.Text = "Дата:";
            // 
            // listViewFinance
            // 
            this.listViewFinance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Date,
            this.Gain,
            this.Costs,
            this.Profit});
            this.listViewFinance.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewFinance.FullRowSelect = true;
            this.listViewFinance.GridLines = true;
            this.listViewFinance.HideSelection = false;
            this.listViewFinance.Location = new System.Drawing.Point(199, 122);
            this.listViewFinance.Name = "listViewFinance";
            this.listViewFinance.Size = new System.Drawing.Size(630, 196);
            this.listViewFinance.TabIndex = 64;
            this.listViewFinance.UseCompatibleStateImageBehavior = false;
            this.listViewFinance.View = System.Windows.Forms.View.Details;
            this.listViewFinance.SelectedIndexChanged += new System.EventHandler(this.listViewFinance_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Gain
            // 
            this.Gain.DisplayIndex = 1;
            this.Gain.Text = "Доходы";
            this.Gain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gain.Width = 185;
            // 
            // Costs
            // 
            this.Costs.DisplayIndex = 2;
            this.Costs.Text = "Расходы";
            this.Costs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Costs.Width = 136;
            // 
            // Date
            // 
            this.Date.DisplayIndex = 3;
            this.Date.Text = "Дата:";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 125;
            // 
            // textBoxCosts
            // 
            this.textBoxCosts.Location = new System.Drawing.Point(12, 201);
            this.textBoxCosts.Name = "textBoxCosts";
            this.textBoxCosts.Size = new System.Drawing.Size(171, 20);
            this.textBoxCosts.TabIndex = 63;
            this.textBoxCosts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGains_KeyPress);
            // 
            // labelCosts
            // 
            this.labelCosts.AutoSize = true;
            this.labelCosts.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCosts.Location = new System.Drawing.Point(9, 184);
            this.labelCosts.Name = "labelCosts";
            this.labelCosts.Size = new System.Drawing.Size(59, 15);
            this.labelCosts.TabIndex = 62;
            this.labelCosts.Text = "Расходы";
            // 
            // textBoxGains
            // 
            this.textBoxGains.Location = new System.Drawing.Point(12, 161);
            this.textBoxGains.Name = "textBoxGains";
            this.textBoxGains.Size = new System.Drawing.Size(171, 20);
            this.textBoxGains.TabIndex = 61;
            this.textBoxGains.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGains_KeyPress);
            // 
            // labelGains
            // 
            this.labelGains.AutoSize = true;
            this.labelGains.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGains.Location = new System.Drawing.Point(9, 144);
            this.labelGains.Name = "labelGains";
            this.labelGains.Size = new System.Drawing.Size(56, 15);
            this.labelGains.TabIndex = 60;
            this.labelGains.Text = "Доходы:";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(673, 324);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(156, 48);
            this.buttonDel.TabIndex = 59;
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
            this.buttonEdit.Location = new System.Drawing.Point(511, 324);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(156, 48);
            this.buttonEdit.TabIndex = 58;
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
            this.buttonAdd.Location = new System.Drawing.Point(349, 324);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(156, 48);
            this.buttonAdd.TabIndex = 57;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ITDevelopment_Project.Properties.Resources._1485088570logo1_big;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(817, 98);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 67;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Profit
            // 
            this.Profit.Text = "Прибыль";
            this.Profit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Profit.Width = 119;
            // 
            // FormFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 386);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.dateTimePickerFinance);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.listViewFinance);
            this.Controls.Add(this.textBoxCosts);
            this.Controls.Add(this.labelCosts);
            this.Controls.Add(this.textBoxGains);
            this.Controls.Add(this.labelGains);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormFinance";
            this.Text = "Доходы/расходы";
            this.Load += new System.EventHandler(this.FormFinance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFinance;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ListView listViewFinance;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Gain;
        private System.Windows.Forms.ColumnHeader Costs;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.TextBox textBoxCosts;
        private System.Windows.Forms.Label labelCosts;
        private System.Windows.Forms.TextBox textBoxGains;
        private System.Windows.Forms.Label labelGains;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ColumnHeader Profit;
    }
}