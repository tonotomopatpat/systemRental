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

        public void ShowUserControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //show dashboard by default
            ShowUserControl(new dashboardPage());
            //timer date and time
            timer1.Start();

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            ShowUserControl(new roomPage());
        }

        private void btnGoToRooms_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as frmMain;
            if (parentForm != null)
            {
                parentForm.ShowUserControl(new roomPage());
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmLogin loginform = new frmLogin();
                loginform.Show();
                this.Close();
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            using (frmLoginPrompt loginPrompt = new frmLoginPrompt())
            {
                var loginResult = loginPrompt.ShowDialog();

                if (loginResult == DialogResult.OK)
                {
                    //ff login successful, open Add Account form
                    using (frmAddAccount addAccountForm = new frmAddAccount())
                    {
                        addAccountForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("You must login to add a new account.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
