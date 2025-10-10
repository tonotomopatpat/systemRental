using System;
using System.Data;
using System.Windows.Forms;

namespace systemRental
{
    public partial class frmAddAccount : Form
    {
        Class1 db = new Class1("localhost", "rentalSystem", "root", "manzano");

        public frmAddAccount()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //check if username already exists
                string checkSql = $"SELECT * FROM tbl_accounts WHERE username = '{txtUsername.Text}'";
                DataTable dt = db.GetData(checkSql);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username already exists. Choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //insert new account
                string insertSql = $"INSERT INTO tbl_accounts (username, password) VALUES ('{txtUsername.Text}', '{txtPassword.Text}')";
                db.executeSQL(insertSql);

                if (db.rowAffected > 0)
                {
                    MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to create account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                btnShow.Image = Properties.Resources.hide;
                isPasswordVisible = false;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                btnShow.Image = Properties.Resources.view;
                isPasswordVisible = true;
            }
        }
    }
}
