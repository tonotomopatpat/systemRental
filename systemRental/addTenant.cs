using Mysqlx;
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
    public partial class addTenant : Form
    {
        public string TenantLastName { get { return txtSurname.Text.Trim(); } }
        public string TenantFirstName { get { return txtFirstName.Text.Trim(); } }
        public string TenantMiddleName { get { return txtMiddleName.Text.Trim(); } }
        public string TenantPhone { get { return txtPhoneNo.Text.Trim(); } }
        public string TenantEmergency { get { return guna2Panel1.Text.Trim(); } }

        private Panel dimOverlay;
        private dimOverlayForm overlay;

        public addTenant()
        {
            InitializeComponent();
        }
        private void showDimOverlay()
        {
            dimOverlay = new Panel();
            dimOverlay.BackColor = Color.FromArgb(120, Color.Black);
            dimOverlay.Dock = DockStyle.Fill;
            dimOverlay.Name = "dimOverlay";
            this.Controls.Add(dimOverlay);
            dimOverlay.BringToFront();

            foreach(Control ctrl in this.Controls)
            {
                if(ctrl != dimOverlay)
                {
                    ctrl.Enabled = false;
                }
            }
        }
        private void RemoveDimOverlay()
        {
            if (dimOverlay != null)
            {
                this.Controls.Remove(dimOverlay);
                dimOverlay.Dispose();
                dimOverlay = null;
            }

            foreach (Control ctrl in this.Controls)
            {
                //enbale for 
                ctrl.Enabled = true;
            }
        }

        public void ParentForm_LocationOrSizeChanged(object sender, EventArgs e)
        {
            if(overlay != null)
            {
                overlay.updateBounds(this);
            }
        }
        private int errorcount;

        private void btnNext_Click(object sender, EventArgs e)
        {

            //this is for validation
            try
            {
                errorProvider1.Clear();
                errorcount = 0;

                if (string.IsNullOrEmpty(txtFirstName.Text))
                {
                    errorProvider1.SetError(txtFirstName, "First Name is required.");
                    errorcount++;
                }
                if (string.IsNullOrEmpty(txtSurname.Text))
                {
                    errorProvider1.SetError(txtSurname, "Surname is required.");
                    errorcount++;
                }
                if (string.IsNullOrEmpty(txtPhoneNo.Text))
                {
                    errorProvider1.SetError(txtPhoneNo, "Phone number is required.");
                    errorcount++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error on validation.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (errorcount <= 0)
            {
                errorcount = 0;
                try
                {

                    overlay = new dimOverlayForm(this);
                    overlay.Show();


                    this.LocationChanged += ParentForm_LocationOrSizeChanged;
                    this.SizeChanged += ParentForm_LocationOrSizeChanged;

                    formContract contractForm = new formContract(this, overlay);
                    contractForm.StartPosition = FormStartPosition.Manual;
                    contractForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                    contractForm.Show();


                    int targetXContractForm = this.Location.X;


                    //add the timer
                    Timer timer = new Timer();
                    timer.Interval = 10; //speed of the sliding/animation
                    timer.Tick += (s, ev) =>
                    {
                        if (contractForm.Left > targetXContractForm)
                        {
                            contractForm.Left -= 20;
                            this.Left -= 20;
                        }
                        else
                        {
                            timer.Stop();
                            //this.Hide();
                        }
                    };
                    timer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error on next button" + ex.Message);
                }
            }
        }
    }
}
