namespace systemRental
{
    partial class addroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addroom));
            this.label4 = new System.Windows.Forms.Label();
            this.txtSize = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUnitNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFloor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbUnitType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonthlyRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Unit Size: (sqm)";
            // 
            // txtSize
            // 
            this.txtSize.BorderRadius = 10;
            this.txtSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSize.DefaultText = "";
            this.txtSize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSize.Location = new System.Drawing.Point(332, 92);
            this.txtSize.Name = "txtSize";
            this.txtSize.PlaceholderText = "Unit size (ex: 23.00)";
            this.txtSize.SelectedText = "";
            this.txtSize.Size = new System.Drawing.Size(245, 36);
            this.txtSize.TabIndex = 21;
            // 
            // txtUnitNumber
            // 
            this.txtUnitNumber.BorderRadius = 10;
            this.txtUnitNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitNumber.DefaultText = "";
            this.txtUnitNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUnitNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUnitNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnitNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUnitNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnitNumber.Location = new System.Drawing.Point(32, 92);
            this.txtUnitNumber.Name = "txtUnitNumber";
            this.txtUnitNumber.PlaceholderText = "Unit number (ex: 101A)";
            this.txtUnitNumber.SelectedText = "";
            this.txtUnitNumber.Size = new System.Drawing.Size(251, 36);
            this.txtUnitNumber.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Floor:";
            // 
            // txtFloor
            // 
            this.txtFloor.BorderRadius = 10;
            this.txtFloor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFloor.DefaultText = "";
            this.txtFloor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFloor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFloor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFloor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFloor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFloor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFloor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFloor.Location = new System.Drawing.Point(32, 174);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.PlaceholderText = "Floor (ex: 1,2)";
            this.txtFloor.SelectedText = "";
            this.txtFloor.Size = new System.Drawing.Size(245, 36);
            this.txtFloor.TabIndex = 18;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 26);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Unit number";
            // 
            // cmbUnitType
            // 
            this.cmbUnitType.BackColor = System.Drawing.Color.Transparent;
            this.cmbUnitType.BorderRadius = 5;
            this.cmbUnitType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUnitType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUnitType.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUnitType.ItemHeight = 30;
            this.cmbUnitType.Items.AddRange(new object[] {
            "studio",
            "double",
            "apartment"});
            this.cmbUnitType.Location = new System.Drawing.Point(332, 174);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.Size = new System.Drawing.Size(284, 36);
            this.cmbUnitType.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Unit type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Montly rate:";
            // 
            // txtMonthlyRate
            // 
            this.txtMonthlyRate.BorderRadius = 10;
            this.txtMonthlyRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonthlyRate.DefaultText = "";
            this.txtMonthlyRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMonthlyRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMonthlyRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonthlyRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonthlyRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonthlyRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMonthlyRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonthlyRate.Location = new System.Drawing.Point(29, 274);
            this.txtMonthlyRate.Name = "txtMonthlyRate";
            this.txtMonthlyRate.PlaceholderText = "Monthly rate (ex: 25000)";
            this.txtMonthlyRate.SelectedText = "";
            this.txtMonthlyRate.Size = new System.Drawing.Size(245, 36);
            this.txtMonthlyRate.TabIndex = 25;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 15;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.Gray;
            this.btnAddRoom.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.Location = new System.Drawing.Point(465, 347);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(141, 45);
            this.btnAddRoom.TabIndex = 27;
            this.btnAddRoom.Text = "Done";
            this.btnAddRoom.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // addroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 404);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMonthlyRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUnitType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtUnitNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFloor);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addroom";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox txtSize;
        public Guna.UI2.WinForms.Guna2TextBox txtUnitNumber;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox txtFloor;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUnitType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox txtMonthlyRate;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}