using Org.BouncyCastle.Asn1.Cmp;
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
            set =>lblUnitType.Text = value;
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
        }

        private void LoadOverview()
        {
            string query = @"
                SELECT
                    c.contract_id,
                    c.start_date,
                    c.end_date,
                    c.contract_status,
                    u.unit_number,
                    u.unit_type
                FROM tbl_contracts c
                JOIN tbl_units u ON c.unit_id = u.unit_id
                WHERE c.tenant_ID = " + tenantID + " " +
                "LIMIT 1";
            DataTable dt = db.GetData(query);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                lblContract.Text = row["contract_id"].ToString()+ " year/s";
                lblUnitNo.Text = row["unit_number"].ToString();
                lblUnitType.Text = row["unit_type"].ToString();
                lblContractStatus.Text = row["contract_status"].ToString();

                DateTime start = Convert.ToDateTime(row["start_date"]);
                DateTime end = Convert.ToDateTime(row["end_date"]);
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
    }
}
