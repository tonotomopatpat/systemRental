namespace systemRental
{
    partial class dashboardPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ShadowPanel4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTenantCount = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.utilities = new System.Windows.Forms.DataGridView();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTotalUnits = new System.Windows.Forms.Label();
            this.lblTotalUnitsLabel = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblOccupiedUnits = new System.Windows.Forms.Label();
            this.lblOccupiedLabel = new System.Windows.Forms.Label();
            this.lblAvailableUnits = new System.Windows.Forms.Label();
            this.lblavailable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.guna2ShadowPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2ShadowPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilities)).BeginInit();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1487, 119);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.chartRevenue);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(18, 17);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(713, 831);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            this.chartRevenue.BorderlineColor = System.Drawing.Color.Black;
            this.chartRevenue.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(15, 32);
            this.chartRevenue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(677, 767);
            this.chartRevenue.TabIndex = 4;
            this.chartRevenue.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monthly Revenue";
            // 
            // guna2ShadowPanel4
            // 
            this.guna2ShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel4.Controls.Add(this.lblTenantCount);
            this.guna2ShadowPanel4.Controls.Add(this.guna2PictureBox1);
            this.guna2ShadowPanel4.Controls.Add(this.label3);
            this.guna2ShadowPanel4.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2ShadowPanel4.Location = new System.Drawing.Point(807, 59);
            this.guna2ShadowPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ShadowPanel4.Name = "guna2ShadowPanel4";
            this.guna2ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel4.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel4.Size = new System.Drawing.Size(343, 304);
            this.guna2ShadowPanel4.TabIndex = 2;
            // 
            // lblTenantCount
            // 
            this.lblTenantCount.AutoSize = true;
            this.lblTenantCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTenantCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTenantCount.Location = new System.Drawing.Point(164, 201);
            this.lblTenantCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenantCount.Name = "lblTenantCount";
            this.lblTenantCount.Size = new System.Drawing.Size(24, 28);
            this.lblTenantCount.TabIndex = 2;
            this.lblTenantCount.Text = "0";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(122, 66);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(108, 100);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(116, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Tenants";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.BorderRadius = 5;
            this.guna2CustomGradientPanel1.BorderThickness = 1;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ShadowPanel3);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ShadowPanel2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ShadowPanel1);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ShadowPanel4);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.DarkGray;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(23, 123);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1686, 903);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.utilities);
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(794, 406);
            this.guna2ShadowPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(812, 442);
            this.guna2ShadowPanel3.TabIndex = 14;
            // 
            // utilities
            // 
            this.utilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.utilities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.utilities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.utilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utilities.Location = new System.Drawing.Point(13, 14);
            this.utilities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.utilities.Name = "utilities";
            this.utilities.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.utilities.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.utilities.RowHeadersVisible = false;
            this.utilities.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilities.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.utilities.RowTemplate.Height = 24;
            this.utilities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.utilities.Size = new System.Drawing.Size(783, 404);
            this.utilities.TabIndex = 0;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.lblTotalUnits);
            this.guna2ShadowPanel2.Controls.Add(this.lblTotalUnitsLabel);
            this.guna2ShadowPanel2.Controls.Add(this.guna2PictureBox2);
            this.guna2ShadowPanel2.Controls.Add(this.lblOccupiedUnits);
            this.guna2ShadowPanel2.Controls.Add(this.lblOccupiedLabel);
            this.guna2ShadowPanel2.Controls.Add(this.lblAvailableUnits);
            this.guna2ShadowPanel2.Controls.Add(this.lblavailable);
            this.guna2ShadowPanel2.Controls.Add(this.label2);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(1188, 59);
            this.guna2ShadowPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(418, 304);
            this.guna2ShadowPanel2.TabIndex = 3;
            // 
            // lblTotalUnits
            // 
            this.lblTotalUnits.AutoSize = true;
            this.lblTotalUnits.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalUnits.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalUnits.Location = new System.Drawing.Point(348, 184);
            this.lblTotalUnits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalUnits.Name = "lblTotalUnits";
            this.lblTotalUnits.Size = new System.Drawing.Size(17, 19);
            this.lblTotalUnits.TabIndex = 13;
            this.lblTotalUnits.Text = "0";
            // 
            // lblTotalUnitsLabel
            // 
            this.lblTotalUnitsLabel.AutoSize = true;
            this.lblTotalUnitsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalUnitsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalUnitsLabel.Location = new System.Drawing.Point(276, 184);
            this.lblTotalUnitsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalUnitsLabel.Name = "lblTotalUnitsLabel";
            this.lblTotalUnitsLabel.Size = new System.Drawing.Size(83, 19);
            this.lblTotalUnitsLabel.TabIndex = 12;
            this.lblTotalUnitsLabel.Text = "Total Units:";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(150, 82);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(135, 95);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 11;
            this.guna2PictureBox2.TabStop = false;
            // 
            // lblOccupiedUnits
            // 
            this.lblOccupiedUnits.AutoSize = true;
            this.lblOccupiedUnits.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOccupiedUnits.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOccupiedUnits.Location = new System.Drawing.Point(238, 184);
            this.lblOccupiedUnits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOccupiedUnits.Name = "lblOccupiedUnits";
            this.lblOccupiedUnits.Size = new System.Drawing.Size(17, 19);
            this.lblOccupiedUnits.TabIndex = 10;
            this.lblOccupiedUnits.Text = "0";
            // 
            // lblOccupiedLabel
            // 
            this.lblOccupiedLabel.AutoSize = true;
            this.lblOccupiedLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOccupiedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOccupiedLabel.Location = new System.Drawing.Point(166, 184);
            this.lblOccupiedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOccupiedLabel.Name = "lblOccupiedLabel";
            this.lblOccupiedLabel.Size = new System.Drawing.Size(76, 19);
            this.lblOccupiedLabel.TabIndex = 9;
            this.lblOccupiedLabel.Text = "Occupied:";
            // 
            // lblAvailableUnits
            // 
            this.lblAvailableUnits.AutoSize = true;
            this.lblAvailableUnits.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvailableUnits.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAvailableUnits.Location = new System.Drawing.Point(120, 184);
            this.lblAvailableUnits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableUnits.Name = "lblAvailableUnits";
            this.lblAvailableUnits.Size = new System.Drawing.Size(17, 19);
            this.lblAvailableUnits.TabIndex = 8;
            this.lblAvailableUnits.Text = "0";
            // 
            // lblavailable
            // 
            this.lblavailable.AutoSize = true;
            this.lblavailable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblavailable.ForeColor = System.Drawing.SystemColors.Control;
            this.lblavailable.Location = new System.Drawing.Point(49, 184);
            this.lblavailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblavailable.Name = "lblavailable";
            this.lblavailable.Size = new System.Drawing.Size(76, 19);
            this.lblavailable.TabIndex = 7;
            this.lblavailable.Text = "Available:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(165, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unit Status";
            // 
            // dashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "dashboardPage";
            this.Size = new System.Drawing.Size(1753, 1080);
            this.Load += new System.EventHandler(this.dashboardPage_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.guna2ShadowPanel4.ResumeLayout(false);
            this.guna2ShadowPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2ShadowPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utilities)).EndInit();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblTenantCount;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.Label lblavailable;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label lblOccupiedUnits;
        private System.Windows.Forms.Label lblOccupiedLabel;
        private System.Windows.Forms.Label lblAvailableUnits;
        private System.Windows.Forms.Label lblTotalUnits;
        private System.Windows.Forms.Label lblTotalUnitsLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private System.Windows.Forms.DataGridView utilities;
    }
}
