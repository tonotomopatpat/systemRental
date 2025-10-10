namespace systemRental
{
    partial class historyControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHistoryControl = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryControl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistoryControl
            // 
            this.dgvHistoryControl.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            this.dgvHistoryControl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistoryControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoryControl.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvHistoryControl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistoryControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHistoryControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistoryControl.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHistoryControl.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvHistoryControl.Location = new System.Drawing.Point(27, 80);
            this.dgvHistoryControl.Name = "dgvHistoryControl";
            this.dgvHistoryControl.RowHeadersVisible = false;
            this.dgvHistoryControl.RowTemplate.Height = 21;
            this.dgvHistoryControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoryControl.Size = new System.Drawing.Size(1273, 500);
            this.dgvHistoryControl.TabIndex = 0;
            this.dgvHistoryControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistoryControl_CellContentClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(438, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(380, 70);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Payments History";
            // 
            // historyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvHistoryControl);
            this.Name = "historyControl";
            this.Size = new System.Drawing.Size(1348, 619);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistoryControl;
        private System.Windows.Forms.Label lblName;
    }
}
