using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace systemRental
{
    public partial class calculate : Form
    {
        public int errorcount;
        Class1 newBilling = new Class1("localhost", "rentalSystem", "root", "0902");

        public calculate()
        {
            InitializeComponent();
        }

        private void calculate_Load(object sender, EventArgs e)
        {
            loadTenants();
            dtpMonthOf.Value = DateTime.Now; // Automatically pick current date
        }

        private void loadTenants()
        {
            try
            {
                string connectToDB = "Server=localhost;Database=rentalSystem;Uid=root;Pwd=0902;";
                using (MySqlConnection conn = new MySqlConnection(connectToDB))
                {
                    conn.Open();

                    string query = @"
                        SELECT c.contract_id, t.tenant_id, 
                               CONCAT(t.first_name, ' ', t.middle_name, ' ', t.last_name) AS full_name
                        FROM tbl_contracts c
                        JOIN tbl_tenants t ON c.tenant_id = t.tenant_id
                        WHERE c.contract_status = 'active';
                    ";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbTenants.DataSource = dt;
                    cmbTenants.DisplayMember = "full_name";
                    cmbTenants.ValueMember = "contract_id"; // store contract_id
                    cmbTenants.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tenants: " + ex.Message);
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTenants.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a tenant.");
                    return;
                }

                double water = double.Parse(txtWater.Text);
                double KWH = double.Parse(txtKWH.Text);

                double waterBill = water * 30;
                double kwhBill = KWH * 30;
                double total = waterBill + kwhBill; // rent is removed

                resComputedWater.Text = waterBill.ToString("0.00");
                resComputedKWH.Text = kwhBill.ToString("0.00");
                totalBill.Text = total.ToString("0.00");

                string displayMonth = dtpMonthOf.Value.ToString("yyyy-MM") + "-01";
                string dbMonth = dtpMonthOf.Value.ToString("yyyy-MM");
                labelMessage.Text = $"Your total bill for month {displayMonth} is:";

                if (errorcount > 0) return;

                DataRow selectedRow = ((DataTable)cmbTenants.DataSource).Rows[cmbTenants.SelectedIndex];
                string tenantId = selectedRow["tenant_id"].ToString();
                string contractId = cmbTenants.SelectedValue.ToString();

                // Check if billing already exists
                string checkSql = $"SELECT * FROM tbl_utilities WHERE contract_id = {contractId} AND billing_month = '{dbMonth}'";
                DataTable dtCheck = newBilling.GetData(checkSql);

                if (dtCheck.Rows.Count > 0)
                {
                    // Ask if user wants to override
                    DialogResult drOverride = MessageBox.Show(
                        $"A bill for this tenant for {dbMonth} already exists. Do you want to override it?",
                        "Duplicate Billing",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (drOverride == DialogResult.Yes)
                    {
                        // Update existing billing
                        string updateSql = $"UPDATE tbl_utilities SET water_bill = {waterBill}, electricity_bill = {kwhBill}, total_fees = {total} " +
                                           $"WHERE contract_id = {contractId} AND billing_month = '{dbMonth}'";
                        newBilling.executeSQL(updateSql);

                        if (newBilling.rowAffected > 0)
                        {
                            MessageBox.Show("Billing updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update billing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        // User chose not to override
                        return;
                    }
                }
                else
                {
                    // Insert new billing
                    string insertSql = "INSERT INTO tbl_utilities " +
                                       "(tenant_id, contract_id, billing_month, water_bill, electricity_bill, total_fees) " +
                                       $"VALUES ({tenantId}, {contractId}, '{dbMonth}', {waterBill}, {kwhBill}, {total})";
                    newBilling.executeSQL(insertSql);

                    if (newBilling.rowAffected > 0)
                    {
                        MessageBox.Show("Billing saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to save billing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                //automatically refresh billingsPage if open
                Form mainForm = Application.OpenForms["frmMain"];
                if (mainForm != null)
                {
                    var billingPage = mainForm.Controls.OfType<billingsPage>().FirstOrDefault();
                    if (billingPage != null)
                        billingPage.billingsPage_Load(sender, e);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on computing or saving: " + ex.Message);
            }
        }
    }
}
