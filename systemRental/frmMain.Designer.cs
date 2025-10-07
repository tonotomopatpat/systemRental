namespace systemRental
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnTenants = new Guna.UI2.WinForms.Guna2Button();
            this.btnBilling = new Guna.UI2.WinForms.Guna2Button();
            this.panelSideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGoToRooms = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(172, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1700, 1080);
            this.panelContent.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1655, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1613, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.guna2ControlBox2);
            this.panelHeader.Controls.Add(this.guna2ControlBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(172, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1700, 30);
            this.panelHeader.TabIndex = 2;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderRadius = 25;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDashboard.CustomizableEdges.BottomRight = false;
            this.btnDashboard.CustomizableEdges.TopRight = false;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.DimGray;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Location = new System.Drawing.Point(0, 228);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnDashboard.Size = new System.Drawing.Size(169, 46);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnTenants
            // 
            this.btnTenants.BorderRadius = 25;
            this.btnTenants.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTenants.CheckedState.FillColor = System.Drawing.Color.Silver;
            this.btnTenants.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnTenants.CustomizableEdges.BottomRight = false;
            this.btnTenants.CustomizableEdges.TopRight = false;
            this.btnTenants.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTenants.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTenants.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTenants.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTenants.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTenants.FillColor = System.Drawing.Color.Transparent;
            this.btnTenants.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenants.ForeColor = System.Drawing.Color.DimGray;
            this.btnTenants.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTenants.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTenants.Image = ((System.Drawing.Image)(resources.GetObject("btnTenants.Image")));
            this.btnTenants.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTenants.Location = new System.Drawing.Point(0, 332);
            this.btnTenants.Name = "btnTenants";
            this.btnTenants.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTenants.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnTenants.Size = new System.Drawing.Size(169, 43);
            this.btnTenants.TabIndex = 1;
            this.btnTenants.Text = "Tenants";
            this.btnTenants.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTenants.Click += new System.EventHandler(this.btnTenants_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.BorderRadius = 25;
            this.btnBilling.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBilling.CheckedState.FillColor = System.Drawing.Color.Silver;
            this.btnBilling.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnBilling.CustomizableEdges.BottomRight = false;
            this.btnBilling.CustomizableEdges.TopRight = false;
            this.btnBilling.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBilling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBilling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBilling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBilling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBilling.FillColor = System.Drawing.Color.Transparent;
            this.btnBilling.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilling.ForeColor = System.Drawing.Color.DimGray;
            this.btnBilling.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBilling.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnBilling.Image = ((System.Drawing.Image)(resources.GetObject("btnBilling.Image")));
            this.btnBilling.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBilling.Location = new System.Drawing.Point(0, 410);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBilling.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnBilling.Size = new System.Drawing.Size(169, 71);
            this.btnBilling.TabIndex = 1;
            this.btnBilling.Text = "Billing / Payment";
            this.btnBilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // panelSideBar
            // 
            this.panelSideBar.AutoSize = true;
            this.panelSideBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelSideBar.BorderRadius = 25;
            this.panelSideBar.Controls.Add(this.btnGoToRooms);
            this.panelSideBar.Controls.Add(this.btnLogout);
            this.panelSideBar.Controls.Add(this.lblDate);
            this.panelSideBar.Controls.Add(this.lblTime);
            this.panelSideBar.Controls.Add(this.btnBilling);
            this.panelSideBar.Controls.Add(this.btnTenants);
            this.panelSideBar.Controls.Add(this.btnDashboard);
            this.panelSideBar.CustomizableEdges.BottomRight = false;
            this.panelSideBar.CustomizableEdges.TopRight = false;
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(172, 1080);
            this.panelSideBar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 25;
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.Silver;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.CustomizableEdges.BottomRight = false;
            this.btnLogout.CustomizableEdges.TopRight = false;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Location = new System.Drawing.Point(0, 1035);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnLogout.Size = new System.Drawing.Size(169, 45);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 78);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 26);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 42);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(51, 26);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGoToRooms
            // 
            this.btnGoToRooms.BorderRadius = 25;
            this.btnGoToRooms.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGoToRooms.CheckedState.FillColor = System.Drawing.Color.Silver;
            this.btnGoToRooms.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnGoToRooms.CustomizableEdges.BottomRight = false;
            this.btnGoToRooms.CustomizableEdges.TopRight = false;
            this.btnGoToRooms.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGoToRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGoToRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGoToRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGoToRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGoToRooms.FillColor = System.Drawing.Color.Transparent;
            this.btnGoToRooms.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToRooms.ForeColor = System.Drawing.Color.DimGray;
            this.btnGoToRooms.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGoToRooms.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnGoToRooms.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToRooms.Image")));
            this.btnGoToRooms.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGoToRooms.Location = new System.Drawing.Point(-1, 506);
            this.btnGoToRooms.Name = "btnGoToRooms";
            this.btnGoToRooms.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGoToRooms.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnGoToRooms.Size = new System.Drawing.Size(169, 43);
            this.btnGoToRooms.TabIndex = 14;
            this.btnGoToRooms.Text = "Rooms";
            this.btnGoToRooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGoToRooms.Click += new System.EventHandler(this.btnGoToRooms_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnDashboard;
            this.ClientSize = new System.Drawing.Size(1872, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnTenants;
        private Guna.UI2.WinForms.Guna2Button btnBilling;
        private Guna.UI2.WinForms.Guna2Panel panelSideBar;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnGoToRooms;
    }
}