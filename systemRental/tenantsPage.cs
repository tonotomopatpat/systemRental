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
            flowPeople.Controls.Clear();

            // Include photo_path in the query
            string query = "SELECT tenant_id, first_name, last_name, phone_no, photo_path FROM tbl_tenants";
            DataTable dt = db.GetData(query);

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
                };

                // Load the photo from photo_path
                string photoPath = row["photo_path"].ToString();
                if (!string.IsNullOrEmpty(photoPath) && System.IO.File.Exists(photoPath))
                {
                    btn.Image = Image.FromFile(photoPath);
                }
                else
                {
                    btn.Image = Properties.Resources.user; // fallback, optional
                }

                btn.Click += btnTenant_Click;
                flowPeople.Controls.Add(btn);
            }

            if (dt.Rows.Count > 0)
            {
                lblName.Text = "Please select a tenant";
                lblCompanyNumber.Text = "-";
                selectedTenantID = null;
                panelSecondContent.Controls.Clear();
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

            // --- HIGHLIGHT the selected button ---
            foreach (Control ctrl in flowPeople.Controls)
            {
                if (ctrl is Guna.UI2.WinForms.Guna2Button tenantBtn)
                {
                    tenantBtn.FillColor = Color.White;
                    tenantBtn.ForeColor = Color.Gray;
                }
            }
            btn.FillColor = Color.FromArgb(235, 234, 178); // light yellow highlight
            btn.ForeColor = Color.Black;
            selectedTenantButton = btn;

            try
            {
                // Fetch tenant info including photo_path
                string query = $@"
                    SELECT first_name, last_name, phone_no, photo_path, company_name
                    FROM tbl_tenants
                    WHERE tenant_id = {tenantID}";
                DataTable dt = db.GetData(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    lblName.Text = $"{dr["first_name"]} {dr["last_name"]}";
                    lblCompanyNumber.Text = dr["phone_no"].ToString();

                    
                    lblCompanyName.Text = dr["company_name"].ToString();

                    
                    string photoPath = dr["photo_path"].ToString();
                    if (!string.IsNullOrEmpty(photoPath) && System.IO.File.Exists(photoPath))
                    {
                        guna2PictureBox1.Image = Image.FromFile(photoPath);
                        guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        guna2PictureBox1.Image = Properties.Resources.user; // default image
                        guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    lblName.Text = "N/A";
                    lblCompanyNumber.Text = "N/A";

                    guna2PictureBox1.Image = Properties.Resources.user;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on getting the tenant: " + ex.Message);
            }

            
            LoadControl(new overview(tenantID));
        }



        private void LoadControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelSecondContent.Controls.Clear();
            panelSecondContent.Controls.Add(uc);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (!selectedTenantID.HasValue)
            {
                MessageBox.Show("Please select a tenant first.");
                return;
            }

            historyControl history = new historyControl();
            history.TenantId = selectedTenantID.Value; // pass the selected tenant
            history.LoadPaymentHistory();

            LoadControl(history);
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

            editProfile editProfileForm = new editProfile(selectedTenantID.Value, this);
            editProfileForm.ShowDialog();
        }
        public void RefreshTenants()
        {
            tenantsPage_Load(this, EventArgs.Empty); // reload the flowPeople buttons and data
        }

        private void btnEditContract_Click(object sender, EventArgs e)
        {
            if (!selectedTenantID.HasValue)
            {
                MessageBox.Show("Please select a tenant first.");
                return;
            }

            try
            {
                // Get active contract for the selected tenant
                string query = $"SELECT contract_id FROM tbl_contracts WHERE tenant_id={selectedTenantID.Value} AND contract_status='ACTIVE'";
                DataTable dt = db.GetData(query);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No active contract found for this tenant.");
                    return;
                }

                int contractId = Convert.ToInt32(dt.Rows[0]["contract_id"]);

                // Pass 'this' as parent for automatic refresh
                editContract editForm = new editContract(contractId, this);
                editForm.ShowDialog(); // Use ShowDialog so code waits until form is closed
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening contract editor: " + ex.Message);
            }
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
                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to delete this tenant? This will also free up any occupied units.",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                    return;

                // 1. Get active contract for this tenant
                string contractQuery = $"SELECT unit_id FROM tbl_contracts WHERE tenant_id={selectedTenantID.Value} AND contract_status='ACTIVE'";
                DataTable dtContracts = db.GetData(contractQuery);

                // 2. Update linked units to vacant
                foreach (DataRow row in dtContracts.Rows)
                {
                    int unitId = Convert.ToInt32(row["unit_id"]);
                    string updateUnit = $"UPDATE tbl_units SET status='vacant' WHERE unit_id={unitId}";
                    db.executeSQL(updateUnit);
                }

                // 3. Delete contracts for this tenant
                string deleteContracts = $"DELETE FROM tbl_contracts WHERE tenant_id={selectedTenantID.Value}";
                db.executeSQL(deleteContracts);

                // 4. Delete the tenant
                string deleteTenant = $"DELETE FROM tbl_tenants WHERE tenant_id={selectedTenantID.Value}";
                db.executeSQL(deleteTenant);

                MessageBox.Show("Tenant deleted successfully. All occupied units are now vacant.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh tenants list
                tenantsPage_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting tenant: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim().ToLower().Replace("'", "''");

                string query = @"
            SELECT tenant_id, first_name, last_name, phone_no, photo_path
            FROM tbl_tenants
            WHERE REPLACE(LOWER(first_name), ' ', '') LIKE '%" + searchText.Replace(" ", "") + @"%'
               OR REPLACE(LOWER(last_name), ' ', '') LIKE '%" + searchText.Replace(" ", "") + @"%'";

                DataTable dt = db.GetData(query);

                flowPeople.Controls.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string fullName = $"{row["first_name"]} {row["last_name"]}";

                    var btn = new Guna.UI2.WinForms.Guna2Button
                    {
                        Text = fullName,
                        Tag = row["tenant_id"],
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
                    };

                    string photoPath = row["photo_path"].ToString();
                    if (!string.IsNullOrEmpty(photoPath) && System.IO.File.Exists(photoPath))
                    {
                        btn.Image = Image.FromFile(photoPath);
                    }
                    else
                    {
                        btn.Image = Properties.Resources.user;
                    }

                    btn.Click += btnTenant_Click;
                    flowPeople.Controls.Add(btn);
                }

                // Reset selection
                selectedTenantID = null;
                lblName.Text = dt.Rows.Count > 0 ? "Please select a tenant" : "N/A";
                lblCompanyNumber.Text = dt.Rows.Count > 0 ? "-" : "N/A";
                panelSecondContent.Controls.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching tenants: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
