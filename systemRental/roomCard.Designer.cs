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
            this.lblTenant = new System.Windows.Forms.Label();
            this.lblUnitRate = new System.Windows.Forms.Label();
            this.lblUnitType = new System.Windows.Forms.Label();
            this.lblUnitSize = new System.Windows.Forms.Label();
            this.lblUnitNo = new System.Windows.Forms.Label();
            this.btnStatus = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.Controls.Add(this.btnStatus);
            this.guna2Panel1.Controls.Add(this.lblTenant);
            this.guna2Panel1.Controls.Add(this.lblUnitRate);
            this.guna2Panel1.Controls.Add(this.lblUnitType);
            this.guna2Panel1.Controls.Add(this.lblUnitSize);
            this.guna2Panel1.Controls.Add(this.lblUnitNo);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.PaleTurquoise;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(297, 268);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lblTenant
            // 
            this.lblTenant.AutoSize = true;
            this.lblTenant.BackColor = System.Drawing.Color.Transparent;
            this.lblTenant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenant.Location = new System.Drawing.Point(18, 207);
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
            this.lblUnitRate.Location = new System.Drawing.Point(16, 171);
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
            this.lblUnitType.Location = new System.Drawing.Point(16, 139);
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
            this.lblUnitSize.Location = new System.Drawing.Point(16, 106);
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
            this.btnStatus.Location = new System.Drawing.Point(180, 12);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(93, 45);
            this.btnStatus.TabIndex = 15;
            this.btnStatus.Text = "Status";
            // 
            // roomCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "roomCard";
            this.Size = new System.Drawing.Size(297, 268);
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
    }
}
