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
        Class1 db = new Class1("localhost", "rentalSystem", "root", "0902");
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

                    string status = row["status"].ToString();

                    if (status == "vacant")
                    {
                        card.StatusButton.FillColor = Color.LimeGreen;
                    }
                    else if (status == "occupied")
                    {
                        card.StatusButton.FillColor = Color.Red;
                    }
                    else if (status == "maintenance")
                    {
                        card.StatusButton.FillColor = Color.Orange;
                    }
                    else
                    {
                        card.StatusButton.FillColor = Color.Gray; // default for unknown
                    }

                    // ✅ Make button look like a tag (not a clickable button)
                    //card.StatusButton.FlatStyle = FlatStyle.Flat;
                    //card.StatusButton.FlatAppearance.BorderSize = 0;
                    //card.StatusButton.Enabled = false; // disables click
                    //card.StatusButton.Cursor = Cursors.Default; // no hand icon

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

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            addroom addroom = new addroom();
            addroom.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim().ToLower().Replace(" ", ""); // normalize input

            foreach (roomCard card in flowRooms.Controls.OfType<roomCard>())
            {
                // Normalize the fields we want to search
                string tenantName = card.tenant.ToLower().Replace(" ", "");
                string unitNumber = card.unitNo.ToLower().Replace(" ", "");
                string unitType = card.unitType.ToLower().Replace(" ", "");

                // Check if any of them contains the search string
                bool match = tenantName.Contains(search) || unitNumber.Contains(search) || unitType.Contains(search);

                // Show or hide the card
                card.Visible = match;
            }
        }
    }
}
