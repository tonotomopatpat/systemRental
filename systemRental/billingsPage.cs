using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace systemRental
{
    public partial class billingsPage : UserControl
    {
        Class1 db = new Class1("localhost", "rentalSystem", "root", "manzano");

        public billingsPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.AutoSize = true;
        }

        private string currentFilter = "All";

        public void billingsPage_Load(object sender, EventArgs e)
        {
            // Setup Year ComboBox if empty
            if (cmbYear.Items.Count == 0)
            {
                int currentYear = DateTime.Now.Year;
                for (int y = currentYear - 5; y <= currentYear + 1; y++)
                    cmbYear.Items.Add(y.ToString());
            }

            // Set default current month
            if (cmbMonth.SelectedIndex == -1)
                cmbMonth.SelectedIndex = DateTime.Now.Month - 1;

            // Set default current year
            if (cmbYear.SelectedIndex == -1)
                cmbYear.SelectedItem = DateTime.Now.Year.ToString();

            string selectedMonth = GetSelectedMonthYear();
            if (string.IsNullOrEmpty(selectedMonth))
                return;

            // Fixed query to fetch individual utility bills
            string query = $@"
                SELECT 
                    ut.bill_id,
                    c.contract_id,
                    c.start_date,
                    c.end_date,
                    t.tenant_id,       
                    t.first_name,
                    t.last_name,
                    u.unit_number,
                    u.floor,
                    u.unit_type,
                    u.monthly_rate,
                    ut.billing_month,
                    ut.status,
                    ut.water_bill,
                    ut.electricity_bill,
                    ut.other_charges,
                    (u.monthly_rate + ut.water_bill + ut.electricity_bill + ut.other_charges) AS total_amount
                FROM tbl_contracts c
                JOIN tbl_tenants t ON c.tenant_id = t.tenant_id
                JOIN tbl_units u ON c.unit_id = u.unit_id
                JOIN tbl_utilities ut ON c.contract_id = ut.contract_id
                WHERE ut.billing_month = '{selectedMonth}';
            ";

            DataTable dt = db.GetData(query);
            flowLayoutPanelContents.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string billingMonth = row["billing_month"].ToString();
                string status = row["status"].ToString();

                ContractCard card = new ContractCard
                {
                    BillId = row["bill_id"].ToString(),
                    TenantId = Convert.ToInt32(row["tenant_id"]),
                    TenantName = row["first_name"].ToString() + " " + row["last_name"].ToString(),
                    ContractInfo = "Contract: " +
                                   Convert.ToDateTime(row["start_date"]).ToShortDateString() +
                                   " - " + Convert.ToDateTime(row["end_date"]).ToShortDateString(),
                    Room = "Room: " + row["unit_number"] + " (" + row["unit_type"] + "), Floor " + row["floor"],
                    UnitType = "Type: " + row["unit_type"],
                    TotalUtilities = "Total Balance: ₱ " + Convert.ToDecimal(row["total_amount"]).ToString("0.00") + " (including the Rent)",
                    PaymentStatus = status,
                    Margin = new Padding(20),

                    // Assign individual bills
                    WaterBill = Convert.ToDecimal(row["water_bill"]).ToString("0.00"),
                    ElectricityBill = Convert.ToDecimal(row["electricity_bill"]).ToString("0.00"),
                    OtherCharges = Convert.ToDecimal(row["other_charges"]).ToString("0.00")
                };

                // Filtering logic
                bool addCard = true;

                if (currentFilter == "paid" && status != "paid")
                    addCard = false;
                else if (currentFilter == "unpaid" && status != "unpaid")
                    addCard = false;
                else if (currentFilter == "overdue")
                {
                    if (status != "unpaid")
                        addCard = false;
                    else
                    {
                        DateTime bm = DateTime.ParseExact(billingMonth, "yyyy-MM", null);
                        DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                        if (bm >= now) addCard = false;
                    }
                }

                if (addCard)
                    flowLayoutPanelContents.Controls.Add(card);
            }
        }

        private string GetSelectedMonthYear()
        {
            if (cmbMonth.SelectedIndex == -1 || cmbYear.SelectedIndex == -1)
                return null;

            int month = cmbMonth.SelectedIndex + 1;
            string year = cmbYear.SelectedItem.ToString();
            return $"{year}-{month:D2}";
        }

        private void btnCompute_Click_1(object sender, EventArgs e)
        {
            using (calculate calcForm = new calculate())
            {
                var result = calcForm.ShowDialog();
                if (result == DialogResult.OK)
                    billingsPage_Load(sender, e); // Refresh after compute
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            billingsPage_Load(sender, e);
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            billingsPage_Load(sender, e);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            currentFilter = "All";
            billingsPage_Load(sender, e);
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            currentFilter = "paid";
            billingsPage_Load(sender, e);
        }

        private void btnOverdue_Click(object sender, EventArgs e)
        {
            currentFilter = "overdue";
            billingsPage_Load(sender, e);
        }

        private void btnUnPaid_Click(object sender, EventArgs e)
        {
            currentFilter = "unpaid";
            billingsPage_Load(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim().ToLower().Replace(" ", "");
            foreach (ContractCard card in flowLayoutPanelContents.Controls.OfType<ContractCard>())
            {
                string tenantName = card.TenantName.ToLower().Replace(" ", "");
                card.Visible = tenantName.Contains(search);
            }
        }
    }
}
