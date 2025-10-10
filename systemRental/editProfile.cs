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
    public partial class editProfile : Form
    {
        private int tenantId;
        Class1 db = new Class1("localhost", "rentalSystem", "root", "manzano");

        public editProfile(int tenantId)
        {
            InitializeComponent();
            this.tenantId = tenantId;
        }
        private tenantsPage parentTenantsPage;

        public editProfile(int tenantId, tenantsPage tenantsPage)
        {
            InitializeComponent();
            this.tenantId = tenantId;
            this.parentTenantsPage = tenantsPage;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                int errorcount = 0;

                // First Name
                if (string.IsNullOrEmpty(txtFirstName.Text))
                {
                    errorProvider1.SetError(txtFirstName, "First Name is required.");
                    errorcount++;
                }
                else if (txtFirstName.Text.Any(char.IsDigit))
                {
                    errorProvider1.SetError(txtFirstName, "First Name cannot contain numbers.");
                    errorcount++;
                }

                // Middle Name (optional)
                if (!string.IsNullOrEmpty(txtMiddleName.Text) && txtMiddleName.Text.Any(char.IsDigit))
                {
                    errorProvider1.SetError(txtMiddleName, "Middle Name cannot contain numbers.");
                    errorcount++;
                }

                
                if (string.IsNullOrEmpty(txtSurname.Text))
                {
                    errorProvider1.SetError(txtSurname, "Surname is required.");
                    errorcount++;
                }
                else if (txtSurname.Text.Any(char.IsDigit))
                {
                    errorProvider1.SetError(txtSurname, "Surname cannot contain numbers.");
                    errorcount++;
                }

                
                if (string.IsNullOrEmpty(txtPhoneNo.Text))
                {
                    errorProvider1.SetError(txtPhoneNo, "Phone number is required.");
                    errorcount++;
                }
                else if (!txtPhoneNo.Text.All(char.IsDigit))
                {
                    errorProvider1.SetError(txtPhoneNo, "Phone number must contain only numbers.");
                    errorcount++;
                }

                if (errorcount > 0)
                {
                    return;
                }
                List<string> docs = new List<string>();
                if (cbDriver.Checked)
                    docs.Add("Drivers License");
                if (cbPassport.Checked)
                    docs.Add("Passport");
                if (cbNational.Checked)
                    docs.Add("National ID");
                if (cbVoter.Checked)
                    docs.Add("Voters ID");

                string documentList = string.Join(", ", docs);

                string updateQuery = $@"
                    UPDATE tbl_tenants SET
                        first_name = '{txtFirstName.Text.Trim()}',
                        last_name = '{txtSurname.Text.Trim()}',
                        middle_name = '{txtMiddleName.Text.Trim()}',
                        phone_no = '{txtPhoneNo.Text.Trim()}',
                        emergency_no = '{txtPhoneNo.Text.Trim()}',
                        document_type = '{documentList}'
                    WHERE tenant_id = {tenantId}";

                db.executeSQL(updateQuery);

                if (db.rowAffected > 0)
                {
                    MessageBox.Show("Tenant profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    parentTenantsPage?.RefreshTenants(); //refresh the original tenantsPage

                    this.Close();


                }
                else
                {
                    MessageBox.Show("No changes detected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating tenant: " + ex.Message);
            }
        }

        private void editProfile_Load(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT * FROM tbl_tenants WHERE tenant_id = {tenantId}";
                DataTable dt = db.GetData(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                    txtFirstName.Text = dr["first_name"].ToString();
                    txtSurname.Text = dr["last_name"].ToString();
                    txtMiddleName.Text = dr["middle_name"].ToString();
                    txtPhoneNo.Text = dr["phone_no"].ToString();

                    string docs = dr["document_type"].ToString();
                    cbDriver.Checked = docs.Contains("Drivers License");
                    cbPassport.Checked = docs.Contains("Passport");
                    cbNational.Checked = docs.Contains("National ID");
                    cbVoter.Checked = docs.Contains("Voters ID");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tenant data: " + ex.Message);
            }
        }
    }
}
