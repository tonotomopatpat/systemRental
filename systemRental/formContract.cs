using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemRental
{
    public partial class formContract : Form
    {
        private addTenant mainOriginalForm;
        private dimOverlayForm mainOverlay;
        //private int errorcount;


        public formContract(addTenant originalForm, dimOverlayForm overlay)
        {
            InitializeComponent();
            mainOriginalForm = originalForm;
            mainOverlay = overlay;

            loadAvailableUnits();
        }
        Class1 db = new Class1("localhost", "rentalsystem", "root", "manzano");

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainOriginalForm.Show();
            //mainOriginalForm.StartPosition = FormStartPosition.Manual;

            // Position it off-screen left
            //mainOriginalForm.Location = new Point(this.Location.X - this.Width, this.Location.Y);

            int targetXContractForm = this.Location.X + this.Width; //contract form slides right
            int targetXAddTenant = mainOriginalForm.Location.X;


            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += (s, ev) =>
            {
                if (this.Left < targetXContractForm)
                {
                    mainOriginalForm.Left += 20;
                    this.Left += 20;
                }
                else
                {
                    timer.Stop();
                    this.Hide();

                    if(mainOverlay != null)
                    {
                        mainOverlay.Close();
                        mainOverlay.Dispose();
                    }
                    mainOriginalForm.Left = (Screen.PrimaryScreen.WorkingArea.Width - mainOriginalForm.Width) / 2;
                    mainOriginalForm.LocationChanged -= mainOriginalForm.ParentForm_LocationOrSizeChanged;
                    mainOriginalForm.SizeChanged -= mainOriginalForm.ParentForm_LocationOrSizeChanged;
                }
            };
            timer.Start();
        }

        private void loadAvailableUnits()
        {
            try
            {
                string sql = "SELECT unit_id, unit_number FROM tbl_units WHERE status = 'vacant'";
                DataTable dt = db.GetData(sql);

                cmbUnit.DataSource = dt;
                cmbUnit.DisplayMember = "unit_number";
                cmbUnit.ValueMember = "unit_id";
                cmbUnit.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("error loading units: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            int errorcount = 0;

            //need because nasa ibang form yung mga txtbox, so i public them, then did this.
            if (string.IsNullOrWhiteSpace(mainOriginalForm.TenantLastName))
            {
                MessageBox.Show("Last name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorcount++;
            }
            if (string.IsNullOrWhiteSpace(mainOriginalForm.TenantFirstName))
            {
                MessageBox.Show("First name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorcount++;
            }
            if (string.IsNullOrWhiteSpace(mainOriginalForm.TenantPhone))
            {
                MessageBox.Show("Phone number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorcount++;
            }
            if (cmbUnit.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a unit.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorcount++;
            }
            if (string.IsNullOrWhiteSpace(txtDeposit.Text))
            {
                MessageBox.Show("Deposit is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorcount++;
            }

            if (errorcount > 0) return;

            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to save this tenant and contract?",
                                                  "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    
                    string insertTenant = "INSERT INTO tbl_tenants " +
                        "(last_name, first_name, middle_name, phone_no, emergency_no) VALUES (" +
                        $"'{mainOriginalForm.TenantLastName}', '{mainOriginalForm.TenantFirstName}', " +
                        $"'{mainOriginalForm.TenantMiddleName}', '{mainOriginalForm.TenantPhone}', " +
                        $"'{mainOriginalForm.TenantEmergency}')";

                    db.executeSQL(insertTenant);

                    if (db.rowAffected > 0)
                    {
                        
                        DataTable dt = db.GetData("SELECT tenant_id FROM tbl_tenants " +
                          $"WHERE last_name = '{mainOriginalForm.TenantLastName}' " +
                          $"AND first_name = '{mainOriginalForm.TenantFirstName}' " +
                          $"AND phone_no = '{mainOriginalForm.TenantPhone}' " +
                          "ORDER BY tenant_id DESC LIMIT 1");

                        int tenantId = Convert.ToInt32(dt.Rows[0]["tenant_id"]);

                        
                        string insertContract = "INSERT INTO tbl_contracts " +
                            "(tenant_id, unit_id, start_date, end_date, deposit_amount, contract_status) VALUES (" +
                            $"'{tenantId}', '{cmbUnit.SelectedValue}', " +
                            $"'{dtpStartRent.Value:yyyy-MM-dd}', '{dtpEndOfRent.Value:yyyy-MM-dd}', " +
                            $"'{txtDeposit.Text}', 'ACTIVE')";

                        db.executeSQL(insertContract);

                        if (db.rowAffected > 0)
                        {
                            MessageBox.Show("Tenant and contract saved successfully.",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            //mainOriginalForm.Close();

                            //this one got from stackoverflow!!!!! dang
                            if (mainOriginalForm != null && !mainOriginalForm.IsDisposed)
                            {
                                mainOriginalForm.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error inserting contract.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error inserting tenant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
