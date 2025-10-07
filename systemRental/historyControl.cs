using System;
using System.Data;
using System.Windows.Forms;

namespace systemRental
{
    public partial class historyControl : UserControl
    {
        Class1 db = new Class1("localhost", "rentalSystem", "root", "0902");

        public historyControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public int TenantId { get; set; } = 0; // 0 = all tenants

        private void historyControl_Load(object sender, EventArgs e)
        {
            LoadPaymentHistory();
        }

        /// <summary>
        /// Loads all payment history from the database
        /// </summary>
        public void LoadPaymentHistory()
        {
            try
            {
                string query = @"
            SELECT 
                p.payment_id AS 'Payment ID',
                p.payment_date AS 'Payment Date',
                p.amount_paid AS 'Amount Paid',
                p.payment_method AS 'Payment Method',
                p.receipt_number AS 'Receipt Number',
                ut.billing_month AS 'Billing Month',
                ut.total_fees AS 'Total Fees',
                CONCAT(t.first_name, ' ', t.middle_name, ' ', t.last_name) AS 'Tenant Name'
            FROM tbl_payments p
            LEFT JOIN tbl_utilities ut ON p.bill_id = ut.bill_id
            LEFT JOIN tbl_tenants t ON ut.tenant_id = t.tenant_id
        ";

                if (TenantId > 0)
                    query += $" WHERE ut.tenant_id = {TenantId}";

                query += " ORDER BY p.payment_date DESC;";

                DataTable dt = db.GetData(query);
                dgvHistoryControl.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    dgvHistoryControl.AutoResizeColumns();
                    dgvHistoryControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvHistoryControl.ReadOnly = true;

                    //hide here
                    dgvHistoryControl.Columns["Payment ID"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No payments found for this tenant.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment history: " + ex.Message);
            }
        }





        /// <summary>
        /// Call this method externally to refresh the DataGridView after a new payment is made
        /// </summary>
        public void RefreshHistory()
        {
            LoadPaymentHistory();
        }

        private void dgvHistoryControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
