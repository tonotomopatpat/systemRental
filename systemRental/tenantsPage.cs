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

        private void tenantsPage_Load(object sender, EventArgs e)
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
                int firstTenantID = Convert.ToInt32(dt.Rows[0]["tenant_id"]);
                selectedTenantID = firstTenantID;
                LoadControl(new overview(firstTenantID));
                lblName.Text = $"{dt.Rows[0]["first_name"]} {dt.Rows[0]["last_name"]}";
                lblCompanyNumber.Text = dt.Rows[0]["phone_no"].ToString();
                //lblContractStatus.Text = row["contract_status"].ToString();
            }
            else
            {
                lblName.Text = "N/A";
                lblCompanyNumber.Text = "N/A";
            }
        }


        private void btnTenant_Click(object sender, EventArgs e)
        {
            var btn = sender as Guna.UI2.WinForms.Guna2Button;
            int tenantID = Convert.ToInt32(btn.Tag);

            selectedTenantID = tenantID;
            //load control is only for UserControls created
            LoadControl(new overview(tenantID));

            //for every click hope it works

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
                MessageBox.Show("error on getting the tenant", ex.Message);
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
    }
}
