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
    public partial class frmMain : Form
    {
        public frmMain(string username)
        {
            InitializeComponent();
        }

        private void ShowUserControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //show dashboard by default
            ShowUserControl(new dashboardPage());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowUserControl(new dashboardPage());
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            ShowUserControl(new billingsPage());
        }

        private void btnTenants_Click(object sender, EventArgs e)
        {
            ShowUserControl(new tenantsPage());
        }
    }
}
