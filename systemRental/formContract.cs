using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace systemRental
{
    public partial class formContract : Form
    {
        private addTenant mainOriginalForm;
        private dimOverlayForm mainOverlay;
        private string avatarPath = "";
        Class1 db = new Class1("localhost", "rentalsystem", "root", "manzano");

        public formContract(addTenant originalForm, dimOverlayForm overlay)
        {
            InitializeComponent();
            mainOriginalForm = originalForm;
            mainOverlay = overlay;

            // Pass avatar from addTenant
            avatarPath = mainOriginalForm.AvatarPath;

            loadAvailableUnits();
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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading units: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainOriginalForm.Show();

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

                    if (mainOverlay != null)
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

        private void btnDone_Click(object sender, EventArgs e)
        {
            int errorcount = 0;

            // Validate fields from addTenant
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
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                MessageBox.Show("Company name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (errorcount > 0) return;

            try
            {
                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to save this tenant and contract?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
                if (dr != DialogResult.Yes) return;

                // --- Copy avatar to central folder ---
                string savedAvatarPath = "";
                if (!string.IsNullOrEmpty(avatarPath) && File.Exists(avatarPath))
                {
                    string targetFolder = Path.Combine(Application.StartupPath, "avatars");
                    if (!Directory.Exists(targetFolder))
                        Directory.CreateDirectory(targetFolder);

                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(avatarPath);
                    savedAvatarPath = Path.Combine(targetFolder, fileName);
                    File.Copy(avatarPath, savedAvatarPath, true);
                }

                // --- Insert tenant ---
                string insertTenant = "INSERT INTO tbl_tenants " +
                    "(last_name, first_name, middle_name, phone_no, emergency_no, document_type, photo_path, company_name) VALUES (" +
                    $"'{mainOriginalForm.TenantLastName}', '{mainOriginalForm.TenantFirstName}', " +
                    $"'{mainOriginalForm.TenantMiddleName}', '{mainOriginalForm.TenantPhone}', " +
                    $"'{mainOriginalForm.TenantEmergency}', '{mainOriginalForm.TenantDocuments}', " +
                    $"'{savedAvatarPath.Replace("\\", "\\\\")}', '{txtCompanyName.Text.Trim()}')";


                db.executeSQL(insertTenant);

                if (db.rowAffected <= 0)
                {
                    MessageBox.Show("Error inserting tenant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // --- Get tenant ID ---
                DataTable dtTenant = db.GetData("SELECT tenant_id FROM tbl_tenants " +
                                               $"WHERE last_name = '{mainOriginalForm.TenantLastName}' " +
                                               $"AND first_name = '{mainOriginalForm.TenantFirstName}' " +
                                               $"AND phone_no = '{mainOriginalForm.TenantPhone}' " +
                                               "ORDER BY tenant_id DESC LIMIT 1");

                int tenantId = Convert.ToInt32(dtTenant.Rows[0]["tenant_id"]);

                // --- Determine duration ---
                string duration = rd1year.Checked ? "1 year" :
                                  rd2year.Checked ? "2 years" :
                                  rd3year.Checked ? "3 years" :
                                  rd4year.Checked ? "4 years" : "Custom";

                // --- Insert contract ---
                string insertContract = "INSERT INTO tbl_contracts " +
                    "(tenant_id, unit_id, start_date, end_date, deposit_amount, contract_status, contract_duration) VALUES (" +
                    $"'{tenantId}', '{cmbUnit.SelectedValue}', " +
                    $"'{dtpStartRent.Value:yyyy-MM-dd}', '{dtpEndOfRent.Value:yyyy-MM-dd}', " +
                    $"'{txtDeposit.Text}', 'ACTIVE', '{duration}')";

                db.executeSQL(insertContract);

                if (db.rowAffected <= 0)
                {
                    MessageBox.Show("Error inserting contract.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // --- Update unit to occupied ---
                string updateUnit = $"UPDATE tbl_units SET status = 'occupied' WHERE unit_id = '{cmbUnit.SelectedValue}'";
                db.executeSQL(updateUnit);

                MessageBox.Show("Tenant and contract saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close forms and show tenantsPage
                Form mainForm = Application.OpenForms["frmMain"];
                this.Close();
                if (mainOriginalForm != null && !mainOriginalForm.IsDisposed)
                    mainOriginalForm.Close();

                if (mainForm != null)
                {
                    var showUserControlMethod = mainForm.GetType().GetMethod("ShowUserControl");
                    if (showUserControlMethod != null)
                        showUserControlMethod.Invoke(mainForm, new object[] { new tenantsPage() });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formContract_Load(object sender, EventArgs e)
        {
            dtpStartRent.Value = DateTime.Now;
            dtpEndOfRent.Value = DateTime.Now;
        }
    }
}
