using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace systemRental
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        //mysql database
        Class1 login = new Class1("localhost", "rentalsystem", "root", "manzano");

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;
            //txtUsername.Focus();
        }
        private bool isPasswordVisible = false;
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                txtPassword.UseSystemPasswordChar= true;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = login.GetData("SELECT * FROM tbl_accounts WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text +"'");
                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Login Successful", "Message");
                    frmMain mainform = new frmMain(txtUsername.Text);
                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "error on btlogin click", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //for dragging dynamiclly the form login
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
