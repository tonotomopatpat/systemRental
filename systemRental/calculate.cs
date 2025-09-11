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
    public partial class calculate : Form
    {
        public int errorcount;
        Class1 login = new Class1("localhost", "rentalSystem", "root", "manzano");
        public calculate()
        {
            InitializeComponent();
        }

        private void calculate_Load(object sender, EventArgs e)
        {
            loadTenants();
        }
        private void loadTenants()
        {
            try
            {
                string connectToDB = "Server=localhost;Database=rentalSystem;Uid=root;Pwd=manzano;";
                using (MySqlConnection conn = new MySqlConnection(connectToDB))
                {
                    conn.Open();
                    //combine ng name
                    string query = "SELECT tenant_id, CONCAT(first_name, ' ', middle_name, ' ', last_name) AS full_name FROM tbl_tenants";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbTenants.DataSource = dt;
                    cmbTenants.DisplayMember = "full_name";
                    cmbTenants.ValueMember = "tenant_id";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error loading on tenants"+ex.Message);
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                double water = double.Parse(txtWater.Text);
                double KWH = double.Parse(txtKWH.Text);
                double rent = double.Parse(txtRent.Text);

                double waterBill = water * 30;
                double kwhBill = KWH * 30;

                resComputedWater.Text = waterBill.ToString("0.00");
                resComputedKWH.Text = kwhBill.ToString("0.00");
                double total = rent + waterBill + kwhBill;
                string month = cmbMonth.SelectedItem?.ToString() ?? "(no month selected)";
                labelMessage.Text = $"Your total bill for month {month} is:";
                totalBill.Text = total.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error on computing" + ex.Message);
            }
        }
    }
}
