using System;
using System.Data;
using System.Windows.Forms;

namespace systemRental
{
    public partial class editContract : Form
    {
        private int contractId;
        private billingsPage parentBillingsPage;
        Class1 db = new Class1("localhost", "rentalSystem", "root", "0902");

        public editContract()
        {
            InitializeComponent();
        }

        public editContract(int contractId)
        {
            InitializeComponent();
            this.contractId = contractId;
        }

        public editContract(int contractId, billingsPage parent)
        {
            InitializeComponent();
            this.contractId = contractId;
            this.parentBillingsPage = parent;
        }

        private void editContract_Load(object sender, EventArgs e)
        {
            if (contractId == 0) { MessageBox.Show("Contract ID is 0!"); return; }

            try
            {
                // Load units from database
                DataTable units = db.GetData("SELECT unit_id, unit_number FROM tbl_units");
                cmbUnit.DataSource = units;
                cmbUnit.ValueMember = "unit_id";
                cmbUnit.DisplayMember = "unit_number"; // show unit_number in combo box

                // Load contract data
                string query = $"SELECT * FROM tbl_contracts WHERE contract_id = {contractId}";
                DataTable dt = db.GetData(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                    // Set contract duration radio buttons
                    string duration = dr["contract_duration"].ToString();
                    rd1year.Checked = duration == "1 year";
                    rd2year.Checked = duration == "2 years";
                    rd3year.Checked = duration == "3 years";
                    rd4year.Checked = duration == "4 years";

                    // Set selected unit in combo box
                    cmbUnit.SelectedValue = Convert.ToInt32(dr["unit_id"]);

                    // Set deposit
                    txtDeposit.Text = dr["deposit_amount"].ToString();

                    // Set start and end dates
                    dtpStartRent.Value = Convert.ToDateTime(dr["start_date"]);
                    dtpEndOfRent.Value = Convert.ToDateTime(dr["end_date"]);
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
                // Determine selected duration as string
                string duration = rd1year.Checked ? "1 year" :
                                  rd2year.Checked ? "2 years" :
                                  rd3year.Checked ? "3 years" :
                                  rd4year.Checked ? "4 years" : "";

                string updateQuery = $@"
            UPDATE tbl_contracts SET
                contract_duration = '{duration}',
                unit_id = {cmbUnit.SelectedValue},
                deposit_amount = '{txtDeposit.Text.Trim()}',
                start_date = '{dtpStartRent.Value:yyyy-MM-dd}',
                end_date = '{dtpEndOfRent.Value:yyyy-MM-dd}'
            WHERE contract_id = {contractId}";

                db.executeSQL(updateQuery);

                if (db.rowAffected > 0)
                {
                    MessageBox.Show("Contract updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    parentBillingsPage?.billingsPage_Load(this, EventArgs.Empty); // refresh parent
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No changes detected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating contract: " + ex.Message);
            }
        }
    }
}
