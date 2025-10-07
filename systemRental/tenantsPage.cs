using Mysqlx.Resultset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemRental
{
    public partial class tenantsPage : UserControl
    {
        Class1 db = new Class1("localhost", "rentalSystem", "root", "manzano");
        private int? selectedTenantID = null;
        public tenantsPage()
        {
            InitializeComponent();
        }

        private DataTable getTenants()
        {
            string query = "SELECT tenant_id, first_name, last_name, phone_no FROM tbl_tenants";
            return db.GetData(query);
        }

        public void tenantsPage_Load(object sender, EventArgs e)
        {
            //LoadControl(new overview()); //para default yung overview
            flowPeople.Controls.Clear();

            DataTable dt = getTenants();
            foreach (DataRow row in dt.Rows)
            {
                string fullName = $"{row["first_name"]} {row["last_name"]}";

                var btn = new Guna.UI2.WinForms.Guna2Button
                {
                    Text = fullName,
                    Tag = row["tenant_id"], // store ID
                    Width = flowPeople.ClientSize.Width - 30,
                    Height = 60,
                    Margin = new Padding(5),
                    BorderRadius = 12,
                    TextAlign = HorizontalAlignment.Left,
                    ImageAlign = HorizontalAlignment.Left,
                    ImageSize = new Size(40, 40),
                    FillColor = Color.White,
                    ForeColor = Color.Gray,
                    Cursor = Cursors.Hand,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Image = Properties.Resources.user,
                };

                btn.Click += btnTenant_Click;

                flowPeople.Controls.Add(btn);
            }
            if (dt.Rows.Count > 0)
            {
                //not auto select tenants
                lblName.Text = "Please select a tenant";
                lblCompanyNumber.Text = "-";
                selectedTenantID = null;
                panelSecondContent.Controls.Clear(); //all empty
            }
            else
            {
                lblName.Text = "N/A";
                lblCompanyNumber.Text = "N/A";
                panelSecondContent.Controls.Clear();
            }
        }
        private Guna.UI2.WinForms.Guna2Button selectedTenantButton = null;

        private void btnTenant_Click(object sender, EventArgs e)
        {
            var btn = sender as Guna.UI2.WinForms.Guna2Button;
            int tenantID = Convert.ToInt32(btn.Tag);
            selectedTenantID = tenantID;

            
            foreach (Control ctrl in flowPeople.Controls)
            {
                if (ctrl is Guna.UI2.WinForms.Guna2Button tenantBtn)
                {
                    tenantBtn.FillColor = Color.White;
                    tenantBtn.ForeColor = Color.Gray;
                }
            }

            // --- HIGHLIGHT the selected one ---
            btn.FillColor = Color.FromArgb(235, 234, 178); // light yellow highlight
            btn.ForeColor = Color.Black;
            selectedTenantButton = btn;

            // --- Load overview ---
            LoadControl(new overview(tenantID));

            try
            {
                string query = $@"
            SELECT first_name, last_name, phone_no
            FROM tbl_tenants
            WHERE tenant_id = {tenantID}";
                DataTable dt = db.GetData(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    lblName.Text = $"{dr["first_name"]} {dr["last_name"]}";
                    lblCompanyNumber.Text = dr["phone_no"].ToString();
                }
                else
                {
                    lblName.Text = "N/A";
                    lblCompanyNumber.Text = "N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on getting the tenant: " + ex.Message);
            }
        }


        private void LoadControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelSecondContent.Controls.Clear();
            panelSecondContent.Controls.Add(uc);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            LoadControl(new historyControl());
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            if (selectedTenantID.HasValue)
                LoadControl(new overview(selectedTenantID.Value));
            else
                MessageBox.Show("Please select a tenant first.");
        }

        private void btnAddTenants_Click(object sender, EventArgs e)
        {
            addTenant addTenant = new addTenant();
            addTenant.Show();
        }

        private void btnGoToRooms_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as frmMain;
            if (parentForm != null)
            {
                parentForm.ShowUserControl(new roomPage());
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if (!selectedTenantID.HasValue)
            {
                MessageBox.Show("Please select a tenant first.");
                return;
            }

            editProfile editProfileForm = new editProfile(selectedTenantID.Value);
            editProfileForm.ShowDialog();
        }

        private void btnEditContract_Click(object sender, EventArgs e)
        {
            editContract editContract = new editContract();
            editContract.Show();
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            if (!selectedTenantID.HasValue)
            {
                MessageBox.Show("Please select a tenant first.");
                return;
            }
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete thi account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string query = $"DELETE FROM tbl_tenants WHERE tenant_id={selectedTenantID.Value}";
                    db.executeSQL(query);

                    MessageBox.Show("Tenant deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //refresh tenants
                    tenantsPage_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting tenant: " + ex.Message);
            }
        }
    }
}
