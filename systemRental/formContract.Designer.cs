namespace systemRental
{
    partial class formContract
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formContract));
            this.dtpStartRent = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rd4year = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rd3year = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rd2year = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rd1year = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbUnit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpEndOfRent = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnDone = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtDeposit = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCompanyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartRent
            // 
            this.dtpStartRent.Checked = true;
            this.dtpStartRent.FillColor = System.Drawing.Color.Cyan;
            this.dtpStartRent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartRent.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartRent.Location = new System.Drawing.Point(512, 149);
            this.dtpStartRent.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartRent.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartRent.Name = "dtpStartRent";
            this.dtpStartRent.Size = new System.Drawing.Size(200, 36);
            this.dtpStartRent.TabIndex = 36;
            this.dtpStartRent.Value = new System.DateTime(2025, 9, 13, 8, 12, 54, 473);
            // 
            // rd4year
            // 
            this.rd4year.AutoSize = true;
            this.rd4year.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd4year.CheckedState.BorderThickness = 0;
            this.rd4year.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd4year.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rd4year.CheckedState.InnerOffset = -4;
            this.rd4year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd4year.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd4year.Location = new System.Drawing.Point(301, 102);
            this.rd4year.Name = "rd4year";
            this.rd4year.Size = new System.Drawing.Size(84, 30);
            this.rd4year.TabIndex = 35;
            this.rd4year.Text = "4 years";
            this.rd4year.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rd4year.UncheckedState.BorderThickness = 2;
            this.rd4year.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rd4year.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rd3year
            // 
            this.rd3year.AutoSize = true;
            this.rd3year.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd3year.CheckedState.BorderThickness = 0;
            this.rd3year.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd3year.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rd3year.CheckedState.InnerOffset = -4;
            this.rd3year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd3year.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd3year.Location = new System.Drawing.Point(301, 58);
            this.rd3year.Name = "rd3year";
            this.rd3year.Size = new System.Drawing.Size(84, 30);
            this.rd3year.TabIndex = 34;
            this.rd3year.Text = "3 years";
            this.rd3year.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rd3year.UncheckedState.BorderThickness = 2;
            this.rd3year.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rd3year.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rd2year
            // 
            this.rd2year.AutoSize = true;
            this.rd2year.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd2year.CheckedState.BorderThickness = 0;
            this.rd2year.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd2year.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rd2year.CheckedState.InnerOffset = -4;
            this.rd2year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd2year.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2year.Location = new System.Drawing.Point(94, 100);
            this.rd2year.Name = "rd2year";
            this.rd2year.Size = new System.Drawing.Size(84, 30);
            this.rd2year.TabIndex = 33;
            this.rd2year.Text = "2 years";
            this.rd2year.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rd2year.UncheckedState.BorderThickness = 2;
            this.rd2year.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rd2year.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rd1year
            // 
            this.rd1year.AutoSize = true;
            this.rd1year.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd1year.CheckedState.BorderThickness = 0;
            this.rd1year.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd1year.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rd1year.CheckedState.InnerOffset = -4;
            this.rd1year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd1year.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1year.Location = new System.Drawing.Point(94, 58);
            this.rd1year.Name = "rd1year";
            this.rd1year.Size = new System.Drawing.Size(72, 30);
            this.rd1year.TabIndex = 32;
            this.rd1year.Text = "1 year";
            this.rd1year.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rd1year.UncheckedState.BorderThickness = 2;
            this.rd1year.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rd1year.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(35, 12);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(70, 28);
            this.guna2HtmlLabel9.TabIndex = 31;
            this.guna2HtmlLabel9.Text = "Contract";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(512, 115);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(94, 28);
            this.guna2HtmlLabel7.TabIndex = 30;
            this.guna2HtmlLabel7.Text = "Start of Rent";
            // 
            // cmbUnit
            // 
            this.cmbUnit.BackColor = System.Drawing.Color.Transparent;
            this.cmbUnit.BorderRadius = 5;
            this.cmbUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUnit.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUnit.ItemHeight = 30;
            this.cmbUnit.Location = new System.Drawing.Point(25, 179);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(284, 36);
            this.cmbUnit.TabIndex = 40;
            // 
            // dtpEndOfRent
            // 
            this.dtpEndOfRent.Checked = true;
            this.dtpEndOfRent.FillColor = System.Drawing.Color.Cyan;
            this.dtpEndOfRent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndOfRent.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndOfRent.Location = new System.Drawing.Point(512, 225);
            this.dtpEndOfRent.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndOfRent.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndOfRent.Name = "dtpEndOfRent";
            this.dtpEndOfRent.Size = new System.Drawing.Size(200, 36);
            this.dtpEndOfRent.TabIndex = 39;
            this.dtpEndOfRent.Value = new System.DateTime(2025, 9, 13, 8, 12, 54, 473);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(35, 145);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(32, 28);
            this.guna2HtmlLabel10.TabIndex = 38;
            this.guna2HtmlLabel10.Text = "Unit";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(512, 191);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(87, 28);
            this.guna2HtmlLabel8.TabIndex = 37;
            this.guna2HtmlLabel8.Text = "End of Rent";
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 15;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(3, 341);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 45);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Go back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDone
            // 
            this.btnDone.BorderRadius = 15;
            this.btnDone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDone.FillColor = System.Drawing.Color.Gray;
            this.btnDone.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Image = ((System.Drawing.Image)(resources.GetObject("btnDone.Image")));
            this.btnDone.Location = new System.Drawing.Point(612, 341);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 45);
            this.btnDone.TabIndex = 41;
            this.btnDone.Text = "Done";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.txtCompanyName);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txtDeposit);
            this.guna2Panel1.Controls.Add(this.lblDeposit);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel9);
            this.guna2Panel1.Controls.Add(this.btnDone);
            this.guna2Panel1.Controls.Add(this.btnBack);
            this.guna2Panel1.Controls.Add(this.cmbUnit);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel1.Controls.Add(this.dtpEndOfRent);
            this.guna2Panel1.Controls.Add(this.rd1year);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel10);
            this.guna2Panel1.Controls.Add(this.rd2year);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel1.Controls.Add(this.rd3year);
            this.guna2Panel1.Controls.Add(this.dtpStartRent);
            this.guna2Panel1.Controls.Add(this.rd4year);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.Khaki;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(735, 400);
            this.guna2Panel1.TabIndex = 42;
            // 
            // txtDeposit
            // 
            this.txtDeposit.BorderRadius = 10;
            this.txtDeposit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeposit.DefaultText = "";
            this.txtDeposit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeposit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeposit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeposit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeposit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeposit.Location = new System.Drawing.Point(25, 263);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.PlaceholderText = "Deposit";
            this.txtDeposit.SelectedText = "";
            this.txtDeposit.Size = new System.Drawing.Size(251, 36);
            this.txtDeposit.TabIndex = 42;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(30, 234);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(136, 26);
            this.lblDeposit.TabIndex = 43;
            this.lblDeposit.Text = "Deposit Amount:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderRadius = 10;
            this.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.DefaultText = "";
            this.txtCompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompanyName.Location = new System.Drawing.Point(458, 43);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PlaceholderText = "Company name";
            this.txtCompanyName.SelectedText = "";
            this.txtCompanyName.Size = new System.Drawing.Size(251, 36);
            this.txtCompanyName.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 45;
            this.label1.Text = "Company name";
            // 
            // formContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 400);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formContract";
            this.Text = "formContract";
            this.Load += new System.EventHandler(this.formContract_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartRent;
        private Guna.UI2.WinForms.Guna2RadioButton rd4year;
        private Guna.UI2.WinForms.Guna2RadioButton rd3year;
        private Guna.UI2.WinForms.Guna2RadioButton rd2year;
        private Guna.UI2.WinForms.Guna2RadioButton rd1year;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUnit;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndOfRent;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Button btnDone;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Guna.UI2.WinForms.Guna2TextBox txtDeposit;
        private System.Windows.Forms.Label lblDeposit;
        public Guna.UI2.WinForms.Guna2TextBox txtCompanyName;
        private System.Windows.Forms.Label label1;
    }
}