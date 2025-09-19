using MySql.Data.MySqlClient;
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
    public partial class calculate : Form
    {
        public int errorcount;
        Class1 newBilling = new Class1("localhost", "rentalSystem", "root", "manzano");
        public calculate()
        {
            InitializeComponent();
        }

        private void calculate_Load(object sender, EventArgs e)
        {
            loadTenants();
        }
        private void loadTenants()
        {
            try
            {
                string connectToDB = "Server=localhost;Database=rentalSystem;Uid=root;Pwd=manzano;";
                using (MySqlConnection conn = new MySqlConnection(connectToDB))
                {
                    conn.Open();
                    //combine ng name
                    string query = @"
                        SELECT c.contract_id, CONCAT(t.first_name, ' ', t.middle_name, ' ', t.last_name) AS full_name
                        FROM tbl_contracts c
                        JOIN tbl_tenants t ON c.tenant_id = t.tenant_id
                        WHERE c.contract_status = 'active';
                    ";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbTenants.DataSource = dt;
                    cmbTenants.DisplayMember = "full_name";
                    cmbTenants.ValueMember = "contract_id";
                    cmbTenants.SelectedIndex = -1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error loading on tenants"+ex.Message);
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                double water = double.Parse(txtWater.Text);
                double KWH = double.Parse(txtKWH.Text);
                double rent = double.Parse(txtRent.Text);

                double waterBill = water * 30;
                double kwhBill = KWH * 30;

                resComputedWater.Text = waterBill.ToString("0.00");
                resComputedKWH.Text = kwhBill.ToString("0.00");
                double total = rent + waterBill + kwhBill;
                string displayMonth = dtpMonthOf.Value.ToString("yyyy-MM") + "-01";
                
                string dbMonth = dtpMonthOf.Value.ToString("yyyy-MM");
                labelMessage.Text = $"Your total bill for month {displayMonth} is:";
                totalBill.Text = total.ToString("0.00");

                if(errorcount == 0)
                {
                    try
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to save thsi bill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        
                        if(dr == DialogResult.Yes)
                        {
                            string tenantId = (cmbTenants.SelectedIndex >= 0) ? cmbTenants.SelectedValue.ToString() : "NULL";


                            string contractId = (cmbTenants.SelectedIndex >= 0) ? cmbTenants.SelectedValue.ToString() : "NULL";

                            newBilling.executeSQL("INSERT INTO tbl_utilities " +
                                "(tenant_id, contract_id, billing_month, water_bill, electricity_bill, other_charges, total_fees) VALUES (" +
                                (tenantId == "NULL" ? "NULL" : $"'{tenantId}'") + ", " +
                                (contractId == "NULL" ? "NULL" : $"'{contractId}'") + ", " +
                                $"'{dbMonth}', " +
                                $"{resComputedWater.Text}, " +
                                $"{resComputedKWH.Text}, " +
                                $"{txtRent.Text}, " +
                                $"{totalBill.Text})");
                            if (newBilling.rowAffected > 0)
                            {
                                MessageBox.Show("bililng saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information );
                                //then this line if serve for tbl_logs
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show("error on sabving billing.", "eerror", MessageBoxButtons.OK, MessageBoxIcon.Error );
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error on saving billing,");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("error on computing or parsing" + ex.Message);
            }
        }
    }
}
