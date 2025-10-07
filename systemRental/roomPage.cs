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
        private string currentFilter = "all"; // default: show all
        private void loadRooms()
        {
            try
            {
                // Detach old event handlers
                foreach (roomCard oldCard in flowRooms.Controls.OfType<roomCard>())
                {
                    oldCard.DeleteClicked -= Card_DeleteClicked;
                }

                flowRooms.Controls.Clear();

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

                    card.RoomId = Convert.ToInt32(row["unit_id"]);
                    card.unitNo = row["unit_number"].ToString();
                    card.unitStatus = row["status"].ToString();
                    card.unitSize = row["size"].ToString();
                    card.unitType = row["unit_type"].ToString();
                    card.unitRate = row["monthly_rate"].ToString();
                    card.tenant = string.IsNullOrEmpty(row["tenant_name"].ToString()) ? "-" : row["tenant_name"].ToString();
                    card.Margin = new Padding(20);

                    // Color status
                    switch (card.unitStatus.ToLower())
                    {
                        case "vacant": card.StatusButton.FillColor = Color.LimeGreen; break;
                        case "occupied": card.StatusButton.FillColor = Color.Red; break;
                        case "maintenance": card.StatusButton.FillColor = Color.Orange; break;
                        default: card.StatusButton.FillColor = Color.Gray; break;
                    }

                    // Attach Delete handler
                    card.DeleteClicked += Card_DeleteClicked;
                    card.MaintenanceClicked += Card_MaintenanceClicked;

                    flowRooms.Controls.Add(card);
                }

                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message);
            }
        }
        private void Card_MaintenanceClicked(object sender, EventArgs e)
        {
            roomCard card = sender as roomCard;
            if (card == null) return;

            DialogResult dr = MessageBox.Show(
                $"Are you sure you want to mark {card.unitNo} as maintenance?",
                "Confirm Status Change",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string sql = $"UPDATE tbl_units SET status = 'maintenance' WHERE unit_id = {card.RoomId}";
                db.executeSQL(sql);

                if (db.rowAffected > 0)
                {
                    MessageBox.Show($"{card.unitNo} status updated to Maintenance.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update card UI immediately
                    card.unitStatus = "maintenance";
                    card.StatusButton.FillColor = Color.Orange;
                }
                else
                {
                    MessageBox.Show("Failed to update status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Card_DeleteClicked(object sender, EventArgs e)
        {
            roomCard card = sender as roomCard;
            if (card == null) return;

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this room?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                string sql = $"DELETE FROM tbl_units WHERE unit_id = {card.RoomId}";
                db.executeSQL(sql);

                if (db.rowAffected > 0)
                {
                    MessageBox.Show("Room deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadRooms(); // refresh the list
                }
                else
                {
                    MessageBox.Show("Failed to delete room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ApplyFilters()
        {
            string search = txtSearch.Text.Trim().ToLower().Replace(" ", "");

            foreach (roomCard card in flowRooms.Controls.OfType<roomCard>())
            {
                // Normalize fields
                string tenantName = card.tenant.ToLower().Replace(" ", "");
                string unitNumber = card.unitNo.ToLower().Replace(" ", "");
                string unitType = card.unitType.ToLower().Replace(" ", "");

                // Match search text
                bool searchMatch = tenantName.Contains(search) || unitNumber.Contains(search) || unitType.Contains(search);

                // Match status filter
                bool statusMatch = currentFilter == "all" || card.unitStatus.ToLower() == currentFilter;

                // Show card if both match
                card.Visible = searchMatch && statusMatch;
            }
        }

        private void roomPage_Load(object sender, EventArgs e)
        {
            loadRooms();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            using (addroom addroomForm = new addroom())
            {
                addroomForm.ShowDialog();  // show as modal dialog

                // After the dialog closes, reload rooms
                loadRooms();
            }
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

        private void btnAll_Click(object sender, EventArgs e)
        {
            currentFilter = "all";
            ApplyFilters();
        }

        private void btnVacant_Click(object sender, EventArgs e)
        {
            currentFilter = "vacant";
            ApplyFilters();
        }

        private void btnOccupied_Click(object sender, EventArgs e)
        {
            currentFilter = "occupied";
            ApplyFilters();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            currentFilter = "maintenance";
            ApplyFilters();
        }
    }
}
