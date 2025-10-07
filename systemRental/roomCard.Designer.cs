namespace systemRental
{
    partial class roomCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStatus = new Guna.UI2.WinForms.Guna2Button();
            this.lblTenant = new System.Windows.Forms.Label();
            this.lblUnitRate = new System.Windows.Forms.Label();
            this.lblUnitType = new System.Windows.Forms.Label();
            this.lblUnitSize = new System.Windows.Forms.Label();
            this.lblUnitNo = new System.Windows.Forms.Label();
            this.btnDeleteRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaintenance = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.Controls.Add(this.btnMaintenance);
            this.guna2Panel1.Controls.Add(this.btnDeleteRoom);
            this.guna2Panel1.Controls.Add(this.btnStatus);
            this.guna2Panel1.Controls.Add(this.lblTenant);
            this.guna2Panel1.Controls.Add(this.lblUnitRate);
            this.guna2Panel1.Controls.Add(this.lblUnitType);
            this.guna2Panel1.Controls.Add(this.lblUnitSize);
            this.guna2Panel1.Controls.Add(this.lblUnitNo);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(313, 366);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnStatus
            // 
            this.btnStatus.BorderRadius = 15;
            this.btnStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatus.FillColor = System.Drawing.Color.Gray;
            this.btnStatus.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(157, 13);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(133, 45);
            this.btnStatus.TabIndex = 15;
            this.btnStatus.Text = "Status";
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // lblTenant
            // 
            this.lblTenant.AutoSize = true;
            this.lblTenant.BackColor = System.Drawing.Color.Transparent;
            this.lblTenant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenant.Location = new System.Drawing.Point(16, 251);
            this.lblTenant.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTenant.Name = "lblTenant";
            this.lblTenant.Size = new System.Drawing.Size(50, 16);
            this.lblTenant.TabIndex = 13;
            this.lblTenant.Text = "Tenant";
            // 
            // lblUnitRate
            // 
            this.lblUnitRate.AutoSize = true;
            this.lblUnitRate.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitRate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUnitRate.Location = new System.Drawing.Point(16, 202);
            this.lblUnitRate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblUnitRate.Name = "lblUnitRate";
            this.lblUnitRate.Size = new System.Drawing.Size(64, 16);
            this.lblUnitRate.TabIndex = 12;
            this.lblUnitRate.Text = "Unit Rate";
            // 
            // lblUnitType
            // 
            this.lblUnitType.AutoSize = true;
            this.lblUnitType.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUnitType.Location = new System.Drawing.Point(16, 157);
            this.lblUnitType.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblUnitType.Name = "lblUnitType";
            this.lblUnitType.Size = new System.Drawing.Size(66, 16);
            this.lblUnitType.TabIndex = 11;
            this.lblUnitType.Text = "Unit Type";
            // 
            // lblUnitSize
            // 
            this.lblUnitSize.AutoSize = true;
            this.lblUnitSize.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitSize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUnitSize.Location = new System.Drawing.Point(16, 112);
            this.lblUnitSize.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblUnitSize.Name = "lblUnitSize";
            this.lblUnitSize.Size = new System.Drawing.Size(32, 16);
            this.lblUnitSize.TabIndex = 10;
            this.lblUnitSize.Text = "Size";
            // 
            // lblUnitNo
            // 
            this.lblUnitNo.AutoSize = true;
            this.lblUnitNo.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUnitNo.Location = new System.Drawing.Point(16, 68);
            this.lblUnitNo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblUnitNo.Name = "lblUnitNo";
            this.lblUnitNo.Size = new System.Drawing.Size(57, 16);
            this.lblUnitNo.TabIndex = 9;
            this.lblUnitNo.Text = "Unit No:";
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRoom.BorderRadius = 8;
            this.btnDeleteRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteRoom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.DimGray;
            this.btnDeleteRoom.Location = new System.Drawing.Point(197, 303);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(73, 46);
            this.btnDeleteRoom.TabIndex = 16;
            this.btnDeleteRoom.Text = "Delete Room";
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaintenance.BorderRadius = 8;
            this.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaintenance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMaintenance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.DimGray;
            this.btnMaintenance.Location = new System.Drawing.Point(29, 303);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(109, 46);
            this.btnMaintenance.TabIndex = 17;
            this.btnMaintenance.Text = "Set Maintenance";
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // roomCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "roomCard";
            this.Size = new System.Drawing.Size(313, 366);
            this.Load += new System.EventHandler(this.roomCard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblTenant;
        private System.Windows.Forms.Label lblUnitRate;
        private System.Windows.Forms.Label lblUnitType;
        private System.Windows.Forms.Label lblUnitSize;
        private System.Windows.Forms.Label lblUnitNo;
        public Guna.UI2.WinForms.Guna2Button btnStatus;
        private Guna.UI2.WinForms.Guna2Button btnDeleteRoom;
        private Guna.UI2.WinForms.Guna2Button btnMaintenance;
    }
}
