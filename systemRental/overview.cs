using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace systemRental
{
    public partial class overview : UserControl
    {
        Class1 db = new Class1("localhost", "rentalSystem", "root", "manzano");
        private int tenantID;

        public overview(int tenantID)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.tenantID = tenantID;
        }

        public string contractID
        {
            get => lblContract.Text;
            set => lblContract.Text = value;
        }

        public string unitNumber
        {
            get => lblUnitNo.Text;
            set => lblUnitNo.Text = value;
        }

        public string unitType
        {
            get => lblUnitType.Text;
            set => lblUnitType.Text = value;
        }

        public string contractStatus
        {
            get => lblContractStatus.Text;
            set => lblContractStatus.Text = value;
        }

        public string contractDuration
        {
            get => lblDuration.Text;
            set => lblDuration.Text = value;
        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {
        }

        private void overview_Load(object sender, EventArgs e)
        {
            LoadOverview();
            LoadDocuments(); // show documents as checkboxes
        }

        private void LoadOverview()
        {
            string query = @"
                SELECT
                    c.contract_id,
                    c.start_date,
                    c.end_date,
                    c.contract_status,
                    c.contract_duration,
                    u.unit_number,
                    u.unit_type
                FROM tbl_contracts c
                JOIN tbl_units u ON c.unit_id = u.unit_id
                WHERE c.tenant_ID = " + tenantID + @"
                ORDER BY c.contract_id DESC LIMIT 1";

            DataTable dt = db.GetData(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                string dbDuration = row["contract_duration"] == DBNull.Value ? "" : row["contract_duration"].ToString().Trim();
                DateTime start = Convert.ToDateTime(row["start_date"]);
                DateTime end = Convert.ToDateTime(row["end_date"]);

                lblUnitNo.Text = row["unit_number"].ToString();
                lblUnitType.Text = row["unit_type"].ToString();
                lblContractStatus.Text = row["contract_status"].ToString();

                if (!string.IsNullOrEmpty(dbDuration))
                {
                    lblContract.Text = dbDuration;
                }
                else
                {
                    lblContract.Text = ComputeDurationString(start, end);
                }

                lblDuration.Text = $"{start:MM/dd/yyyy} - {end:MM/dd/yyyy}";
            }
            else
            {
                lblContract.Text = "N/A";
                lblUnitNo.Text = "N/A";
                lblUnitType.Text = "N/A";
                lblContractStatus.Text = "N/A";
                lblDuration.Text = "N/A";
            }
        }

        private string ComputeDurationString(DateTime start, DateTime end)
        {
            int years = end.Year - start.Year;
            if (end.Month < start.Month || (end.Month == start.Month && end.Day < start.Day))
                years--;

            if (years > 0)
                return years == 1 ? "1 year" : $"{years} years";

            int months = (end.Year - start.Year) * 12 + end.Month - start.Month;
            if (end.Day < start.Day) months--;
            if (months > 0)
                return months == 1 ? "1 month" : $"{months} months";

            int days = (end - start).Days;
            return days == 1 ? "1 day" : $"{days} days";
        }

        private void LoadDocuments()
        {
            try
            {
                string query = $"SELECT document_type FROM tbl_tenants WHERE tenant_id = {tenantID}";
                DataTable dt = db.GetData(query);

                //reset all checkboxes
                chkPassport.Checked = false;
                chkVoter.Checked = false;
                chkNational.Checked = false;
                chkDriver.Checked = false;

                if (dt.Rows.Count > 0)
                {
                    string documentTypes = dt.Rows[0]["document_type"].ToString();
                    // assuming comma-separated values like "Passport,Voters ID,National ID,Drivers License"
                    string[] docArray = documentTypes
                        .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(d => d.Trim())
                        .ToArray();

                    chkPassport.Checked = docArray.Contains("Passport");
                    chkVoter.Checked = docArray.Contains("Voters ID");
                    chkNational.Checked = docArray.Contains("National ID");
                    chkDriver.Checked = docArray.Contains("Drivers License");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading documents: " + ex.Message);
            }
        }

        private void lblContract_Click(object sender, EventArgs e)
        {
        }
    }
}
