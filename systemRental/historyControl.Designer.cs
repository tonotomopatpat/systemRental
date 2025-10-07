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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHistoryControl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryControl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistoryControl
            // 
            this.dgvHistoryControl.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvHistoryControl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistoryControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoryControl.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistoryControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistoryControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryControl.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvHistoryControl.Location = new System.Drawing.Point(27, 69);
            this.dgvHistoryControl.Name = "dgvHistoryControl";
            this.dgvHistoryControl.RowHeadersVisible = false;
            this.dgvHistoryControl.RowTemplate.Height = 21;
            this.dgvHistoryControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoryControl.Size = new System.Drawing.Size(1273, 511);
            this.dgvHistoryControl.TabIndex = 0;
            this.dgvHistoryControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistoryControl_CellContentClick);
            // 
            // historyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvHistoryControl);
            this.Name = "historyControl";
            this.Size = new System.Drawing.Size(1348, 619);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistoryControl;
    }
}
