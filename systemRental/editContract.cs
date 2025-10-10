using System;
using System.Data;
using System.Windows.Forms;

namespace systemRental
{
    public partial class editContract : Form
    {
        private int contractId;
        private tenantsPage parentTenantsPage; // reference to parent
        Class1 db = new Class1("localhost", "rentalSystem", "root", "manzano");

        // Constructor with parent reference for auto-refresh
        public editContract(int contractId, tenantsPage parent)
        {
            InitializeComponent();
            this.contractId = contractId;
            this.parentTenantsPage = parent;
        }

        private void editContract_Load(object sender, EventArgs e)
        {
            if (contractId == 0)
            {
                MessageBox.Show("Contract ID is 0!");
                return;
            }

            try
            {
                // Load units for combo box
                DataTable units = db.GetData("SELECT unit_id, unit_number FROM tbl_units");
                cmbUnit.DataSource = units;
                cmbUnit.ValueMember = "unit_id";
                cmbUnit.DisplayMember = "unit_number";

                // Load contract details with tenant info
                string query = $@"
            SELECT c.*, t.company_name
            FROM tbl_contracts c
            INNER JOIN tbl_tenants t ON c.tenant_id = t.tenant_id
            WHERE c.contract_id = {contractId}";
                DataTable dt = db.GetData(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                    // Set duration radio buttons
                    string duration = dr["contract_duration"].ToString();
                    rd1year.Checked = duration == "1 year";
                    rd2year.Checked = duration == "2 years";
                    rd3year.Checked = duration == "3 years";
                    rd4year.Checked = duration == "4 years";

                    cmbUnit.SelectedValue = Convert.ToInt32(dr["unit_id"]);
                    txtDeposit.Text = dr["deposit_amount"].ToString();
                    dtpStartRent.Value = Convert.ToDateTime(dr["start_date"]);
                    dtpEndOfRent.Value = Convert.ToDateTime(dr["end_date"]);

                    // Set company name
                    txtCompanyName.Text = string.IsNullOrWhiteSpace(dr["company_name"].ToString()) ? "-" : dr["company_name"].ToString();
                }
                else
                {
                    MessageBox.Show("Contract not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading contract: " + ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (contractId == 0) return;

            try
            {
                string duration = rd1year.Checked ? "1 year" :
                                  rd2year.Checked ? "2 years" :
                                  rd3year.Checked ? "3 years" :
                                  rd4year.Checked ? "4 years" : "";

                // Update contract table
                string updateQuery = $@"
            UPDATE tbl_contracts SET
                contract_duration = '{duration}',
                unit_id = {cmbUnit.SelectedValue},
                deposit_amount = '{txtDeposit.Text.Trim()}',
                start_date = '{dtpStartRent.Value:yyyy-MM-dd}',
                end_date = '{dtpEndOfRent.Value:yyyy-MM-dd}'
            WHERE contract_id = {contractId}";
                db.executeSQL(updateQuery);

                // Update company_name in tenants table
                DataTable dtTenant = db.GetData($"SELECT tenant_id FROM tbl_contracts WHERE contract_id={contractId}");
                if (dtTenant.Rows.Count > 0)
                {
                    int tenantId = Convert.ToInt32(dtTenant.Rows[0]["tenant_id"]);
                    string updateTenant = $"UPDATE tbl_tenants SET company_name='{txtCompanyName.Text.Trim()}' WHERE tenant_id={tenantId}";
                    db.executeSQL(updateTenant);
                }

                MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Auto-refresh parent tenantsPage
                parentTenantsPage?.RefreshTenants();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating contract: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}