namespace systemRental
{
    partial class calculate
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
            this.txtKWH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWater = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRent = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbTenants = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.resComputedWater = new Guna.UI2.WinForms.Guna2TextBox();
            this.resComputedKWH = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.totalBill = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCompute = new Guna.UI2.WinForms.Guna2Button();
            this.labelMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.dtpMonthOf = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
            // 
            // txtKWH
            // 
            this.txtKWH.BorderRadius = 10;
            this.txtKWH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKWH.DefaultText = "";
            this.txtKWH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKWH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKWH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKWH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKWH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKWH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKWH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKWH.Location = new System.Drawing.Point(29, 202);
            this.txtKWH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKWH.Name = "txtKWH";
            this.txtKWH.PlaceholderText = "Water in (MTR)";
            this.txtKWH.SelectedText = "";
            this.txtKWH.Size = new System.Drawing.Size(200, 36);
            this.txtKWH.TabIndex = 0;
            // 
            // txtWater
            // 
            this.txtWater.BorderRadius = 10;
            this.txtWater.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWater.DefaultText = "";
            this.txtWater.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWater.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWater.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWater.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWater.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWater.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWater.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWater.Location = new System.Drawing.Point(29, 124);
            this.txtWater.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWater.Name = "txtWater";
            this.txtWater.PlaceholderText = "KWH";
            this.txtWater.SelectedText = "";
            this.txtWater.Size = new System.Drawing.Size(200, 32);
            this.txtWater.TabIndex = 1;
            // 
            // txtRent
            // 
            this.txtRent.BorderRadius = 10;
            this.txtRent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRent.DefaultText = "";
            this.txtRent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRent.Location = new System.Drawing.Point(29, 271);
            this.txtRent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRent.Name = "txtRent";
            this.txtRent.PlaceholderText = "Rent";
            this.txtRent.SelectedText = "";
            this.txtRent.Size = new System.Drawing.Size(200, 32);
            this.txtRent.TabIndex = 2;
            // 
            // cmbTenants
            // 
            this.cmbTenants.BackColor = System.Drawing.Color.Transparent;
            this.cmbTenants.BorderRadius = 5;
            this.cmbTenants.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenants.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenants.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenants.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTenants.ItemHeight = 30;
            this.cmbTenants.Location = new System.Drawing.Point(29, 47);
            this.cmbTenants.Name = "cmbTenants";
            this.cmbTenants.Size = new System.Drawing.Size(284, 36);
            this.cmbTenants.TabIndex = 5;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(29, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(107, 28);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Select Tenant:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(29, 89);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(114, 28);
            this.guna2HtmlLabel2.TabIndex = 7;
            this.guna2HtmlLabel2.Text = "Water in (MTR)";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(29, 167);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(144, 28);
            this.guna2HtmlLabel3.TabIndex = 8;
            this.guna2HtmlLabel3.Text = "Electricity in (KWH)";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(29, 245);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(39, 28);
            this.guna2HtmlLabel4.TabIndex = 9;
            this.guna2HtmlLabel4.Text = "Rent:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(29, 310);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(73, 28);
            this.guna2HtmlLabel5.TabIndex = 10;
            this.guna2HtmlLabel5.Text = "Month of:";
            // 
            // resComputedWater
            // 
            this.resComputedWater.BorderRadius = 10;
            this.resComputedWater.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resComputedWater.DefaultText = "";
            this.resComputedWater.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.resComputedWater.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.resComputedWater.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resComputedWater.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resComputedWater.Enabled = false;
            this.resComputedWater.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resComputedWater.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resComputedWater.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resComputedWater.Location = new System.Drawing.Point(452, 89);
            this.resComputedWater.Name = "resComputedWater";
            this.resComputedWater.PlaceholderText = "";
            this.resComputedWater.SelectedText = "";
            this.resComputedWater.Size = new System.Drawing.Size(200, 28);
            this.resComputedWater.TabIndex = 13;
            // 
            // resComputedKWH
            // 
            this.resComputedKWH.BorderRadius = 10;
            this.resComputedKWH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resComputedKWH.DefaultText = "";
            this.resComputedKWH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.resComputedKWH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.resComputedKWH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resComputedKWH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resComputedKWH.Enabled = false;
            this.resComputedKWH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resComputedKWH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resComputedKWH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resComputedKWH.Location = new System.Drawing.Point(452, 157);
            this.resComputedKWH.Name = "resComputedKWH";
            this.resComputedKWH.PlaceholderText = "";
            this.resComputedKWH.SelectedText = "";
            this.resComputedKWH.Size = new System.Drawing.Size(200, 28);
            this.resComputedKWH.TabIndex = 14;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(462, 55);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(133, 28);
            this.guna2HtmlLabel7.TabIndex = 15;
            this.guna2HtmlLabel7.Text = "Computed water:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(452, 123);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(152, 28);
            this.guna2HtmlLabel8.TabIndex = 16;
            this.guna2HtmlLabel8.Text = "Compute Electricity:";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(452, 245);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(73, 28);
            this.guna2HtmlLabel10.TabIndex = 20;
            this.guna2HtmlLabel10.Text = "Total Fee:";
            // 
            // totalBill
            // 
            this.totalBill.BorderRadius = 10;
            this.totalBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalBill.DefaultText = "";
            this.totalBill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalBill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalBill.Enabled = false;
            this.totalBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalBill.Location = new System.Drawing.Point(579, 245);
            this.totalBill.Name = "totalBill";
            this.totalBill.PlaceholderText = "";
            this.totalBill.SelectedText = "";
            this.totalBill.Size = new System.Drawing.Size(174, 28);
            this.totalBill.TabIndex = 24;
            // 
            // btnCompute
            // 
            this.btnCompute.BorderRadius = 10;
            this.btnCompute.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompute.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompute.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompute.FillColor = System.Drawing.Color.Blue;
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCompute.ForeColor = System.Drawing.Color.White;
            this.btnCompute.Location = new System.Drawing.Point(29, 442);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(180, 45);
            this.btnCompute.TabIndex = 25;
            this.btnCompute.Text = "&Compute";
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(452, 211);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(3, 2);
            this.labelMessage.TabIndex = 26;
            this.labelMessage.Text = null;
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 10;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.Blue;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(573, 442);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(180, 45);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "&Print";
            // 
            // dtpMonthOf
            // 
            this.dtpMonthOf.Checked = true;
            this.dtpMonthOf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpMonthOf.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpMonthOf.Location = new System.Drawing.Point(29, 354);
            this.dtpMonthOf.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpMonthOf.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpMonthOf.Name = "dtpMonthOf";
            this.dtpMonthOf.Size = new System.Drawing.Size(200, 36);
            this.dtpMonthOf.TabIndex = 28;
            this.dtpMonthOf.Value = new System.DateTime(2025, 9, 17, 10, 53, 36, 540);
            // 
            // calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.dtpMonthOf);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.totalBill);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.resComputedKWH);
            this.Controls.Add(this.resComputedWater);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cmbTenants);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.txtWater);
            this.Controls.Add(this.txtKWH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "calculate";
            this.Load += new System.EventHandler(this.calculate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtKWH;
        private Guna.UI2.WinForms.Guna2TextBox txtWater;
        private Guna.UI2.WinForms.Guna2TextBox txtRent;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenants;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox resComputedWater;
        private Guna.UI2.WinForms.Guna2TextBox resComputedKWH;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2TextBox totalBill;
        private Guna.UI2.WinForms.Guna2Button btnCompute;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelMessage;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMonthOf;
    }
}