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
    public partial class roomPage : UserControl
    {
        public roomPage()
        {
            InitializeComponent();
        }
        Class1 db = new Class1("localhost", "rentalSystem", "root", "manzano");
        private void loadRooms()
        {
            try
            {
                string sql = @"
                    SELECT u.unit_id, u.unit_number, u.status, u.size, u.unit_type, u.monthly_rate,
                        CONCAT(t.first_name, ' ', t.last_name) AS tenant_name
                    FROM tbl_units u
                    LEFT JOIN tbl_contracts c ON u.unit_id = c.unit_id AND c.contract_status = 'active'
                    LEFT JOIN tbl_tenants t ON c.tenant_id = t.tenant_id;";

                DataTable dt = db.GetData(sql);

                

                foreach (DataRow row in dt.Rows)
                {
                    roomCard card = new roomCard();

                    card.unitNo = row["unit_number"].ToString();
                    card.unitStatus = row["status"].ToString();

                    card.unitSize = row["size"].ToString();
                    card.unitType = row["unit_type"].ToString();
                    card.unitRate = row["monthly_rate"].ToString();

                    string tenant = string.IsNullOrEmpty(row["tenant_name"].ToString()) ? "-" : row["tenant_name"].ToString();
                    card.tenant = tenant;
                    card.Margin = new Padding(20);

                    flowRooms.Controls.Add(card);
                }




            }
            catch(Exception ex)
            {
                MessageBox.Show("error on roomPage.cs error on loading rooms"+ ex.Message);
            }
        }

        private void roomPage_Load(object sender, EventArgs e)
        {
            loadRooms();
        }
    }
}
