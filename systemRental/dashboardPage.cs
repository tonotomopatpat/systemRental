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
    public partial class dashboardPage : UserControl
    {
        Class1 db = new Class1("localhost", "rentalSystem", "root", "manzano");
        public dashboardPage()
        {
            InitializeComponent();
        }

        private void dashboardPage_Load(object sender, EventArgs e)
        {
            setPaymentChart();
            loadTenantCount();
            loadUnitStats();
            setUtitityChart();

        }

        private void setUtitityChart()
        {
            try
            {
                string connectToDB = "Server=localhost;Database=rentalSystem;Uid=root;Pwd=manzano;";
                using (MySqlConnection conn = new MySqlConnection(connectToDB))
                {
                    string query = @"
                    SELECT *
                    FROM tbl_utilities
                    WHERE status = 'unpaid' OR status = 'paid'";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    utilities.DataSource = dt;

                    utilities.Columns["tenant_id"].Visible = false;
                    utilities.Columns["bill_id"].Visible = false;
                    utilities.Columns["contract_id"].Visible = false;
                    utilities.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    utilities.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
                    utilities.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    utilities.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    utilities.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
                    utilities.ColumnHeadersHeight = 40;
                    utilities.EnableHeadersVisualStyles = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart: " + ex.Message);
            }
        }
        private void setPaymentChart()
        {
            try
            {
                string connectToDB = "Server=localhost;Database=rentalSystem;Uid=root;Pwd=manzano;";
                using (MySqlConnection conn = new MySqlConnection(connectToDB))
                {
                    string query = @"
                SELECT 
                    MONTH(payment_date) as Month,
                    SUM(amount_paid) as Revenue
                FROM tbl_payments
                WHERE YEAR(payment_date) = YEAR(CURDATE())
                GROUP BY MONTH(payment_date)
                ORDER BY MONTH(payment_date)";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Clear existing chart data
                    chartRevenue.Series.Clear();
                    chartRevenue.Titles.Clear();

                    // Add Series
                    chartRevenue.Series.Add("Series1");
                    chartRevenue.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chartRevenue.Series["Series1"].Color = System.Drawing.Color.Purple;

                    // Add data points
                    foreach (DataRow row in dt.Rows)
                    {
                        int month = Convert.ToInt32(row["Month"]);
                        decimal revenue = Convert.ToDecimal(row["Revenue"]);
                        chartRevenue.Series["Series1"].Points.AddXY(month, revenue);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart: " + ex.Message);
            }
        }
        private void loadTenantCount()
        {
            try
            {
                string connectToDB = "Server=localhost;Database=rentalSystem;Uid=root;Pwd=manzano;";
                using (MySqlConnection conn = new MySqlConnection(connectToDB))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM tbl_tenants";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int totalTenants = Convert.ToInt32(cmd.ExecuteScalar());

                    lblTenantCount.Text = totalTenants.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tenant count: " + ex.Message);
            }
        }
        private void loadUnitStats()
        {
            try
            {
                string connectToDB = "Server=localhost;Database=rentalSystem;Uid=root;Pwd=manzano;";
                using (MySqlConnection conn = new MySqlConnection(connectToDB))
                {
                    conn.Open();

                    string query = @"SELECT 
                        COUNT(CASE WHEN status = 'vacant' THEN 1 END) as AvailableUnits,
                        COUNT(CASE WHEN status = 'occupied' THEN 1 END) as OccupiedUnits,
                        COUNT(*) as TotalUnits
                     FROM tbl_units";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int total = Convert.ToInt32(reader["TotalUnits"]);
                        int available = Convert.ToInt32(reader["AvailableUnits"]);
                        int occupied = Convert.ToInt32(reader["OccupiedUnits"]);

                        // Display the numbers
                        lblTotalUnits.Text = total.ToString();
                        lblAvailableUnits.Text = available.ToString();
                        lblOccupiedUnits.Text = occupied.ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading unit stats: " + ex.Message);
            }
        }


    }
 }
