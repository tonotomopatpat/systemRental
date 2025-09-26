using Guna.UI2.WinForms;
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
    public partial class billingsPage : UserControl
    {
        Class1 db = new Class1("localhost", "rentalSystem", "root", "manzano");
        public billingsPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.AutoSize = true;
        }

        private void billingsPage_Load(object sender, EventArgs e)
        {
            string selectedMonth = GetSelectedMonthYear();
            if (string.IsNullOrEmpty(selectedMonth))
                return;

            string query = $@"
                    SELECT 
                        c.contract_id,
                        c.start_date,
                        c.end_date,
                        t.first_name,
                        t.last_name,
                        u.unit_number,
                        u.floor,
                        u.unit_type,
                        u.monthly_rate,
                        COALESCE(SUM(ut.total_fees), 0) AS total_utilities,
                        (u.monthly_rate + COALESCE(SUM(ut.total_fees), 0)) AS total_amount
                    FROM tbl_contracts c
                    JOIN tbl_tenants t ON c.tenant_id = t.tenant_id
                    JOIN tbl_units u ON c.unit_id = u.unit_id
                    JOIN tbl_utilities ut ON c.contract_id = ut.contract_id
                    WHERE ut.billing_month = '{selectedMonth}'
                    GROUP BY 
                        c.contract_id, 
                        c.start_date, 
                        c.end_date, 
                        t.first_name, 
                        t.last_name, 
                        u.unit_number, 
                        u.floor, 
                        u.unit_type, 
                        u.monthly_rate;
                ";



            DataTable dt = db.GetData(query);
            flowLayoutPanelContents.Controls.Clear();

            //name,contract,stat date,end date, unit number, total balance
            foreach (DataRow row in dt.Rows)
            {
                ContractCard card = new ContractCard
                {
                    TenantName = row["first_name"].ToString() + " " + row["last_name"].ToString(),
                    ContractInfo = "Contract: " +
                        Convert.ToDateTime(row["start_date"]).ToShortDateString() +
                        " - " + Convert.ToDateTime(row["end_date"]).ToShortDateString(),
                    Room = "Room: " + row["unit_number"] + " (" + row["unit_type"] + "), Floor " + row["floor"],
                    UnitType = "Type: " + row["unit_type"],
                    TotalUtilities = "Total Balance: ₱" + row["total_amount"],
                    Margin = new Padding(20)
                };

                flowLayoutPanelContents.Controls.Add(card);
            }
            //this is for autoloading the month 
            //cmbMonth.SelectedIndex = DateTime.Now.Month;
        }

        private string GetSelectedMonthYear()
        {
            if(cmbMonth.SelectedIndex == -1)
            {
                return null;
            }
            int month = cmbMonth.SelectedIndex + 1;
            string year =DateTime.Now.Year.ToString();

            return $"{year}-{month:D2}";
        }
        
        private void btnCompute_Click_1(object sender, EventArgs e)
        {
            using (calculate calcForm = new calculate())
            {
                calcForm.ShowDialog();
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            billingsPage_Load(sender, e);
        }
    }
}
