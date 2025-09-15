using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemRental
{
    public partial class dimOverlayForm : Form
    {
        public dimOverlayForm(Form owner)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            // Semi-transparent black
            this.BackColor = Color.Black;
            this.Opacity = 0.3; // adjust for dim strength

            // Position exactly over the owner form
            this.StartPosition = FormStartPosition.Manual;
            this.Location = owner.PointToScreen(Point.Empty);
            this.Size = owner.ClientSize;

            // Keep it on top but not in taskbar
            this.ShowInTaskbar = false;
            this.Owner = owner;
            this.TopMost = true;
        }

        public void updateBounds(Form owner)
        {
            this.Location = owner.PointToScreen(Point.Empty);
            this.Size = owner.ClientSize;
        }
        public dimOverlayForm()
        {
            InitializeComponent();
        }

        private void dimOverlayForm_Load(object sender, EventArgs e)
        {

        }
    }
}
