using System;
using System.Data;
using System.Windows.Forms;

namespace systemRental
{
    public partial class frmLoginPrompt : Form
    {
        Class1 db = new Class1("localhost", "rentalSystem", "root", "manzano");

        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public frmLoginPrompt()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter username and password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"SELECT * FROM tbl_accounts WHERE username='{txtUsername.Text}' AND password='{txtPassword.Text}'";
            DataTable dt = db.GetData(query);

            if (dt.Rows.Count > 0)
            {
                // Login success
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private bool isPasswordVisible = false;
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShow.Image = Properties.Resources.hide;
                isPasswordVisible = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShow.Image = Properties.Resources.view;
                isPasswordVisible = true;
            }
        }
    }
}
