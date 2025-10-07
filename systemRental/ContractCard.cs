using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace systemRental
{
    public partial class ContractCard : UserControl
    {
        Class1 db = new Class1("localhost", "rentalSystem", "root", "manzano");
        public ContractCard()
        {
            InitializeComponent();
        }
        public string BillId { get; set; }

        public string TenantName
        {
            get => lblTenant.Text;
            set => lblTenant.Text = value;
        }

        public string Room
        {
            get => lblRoom.Text;
            set => lblRoom.Text = value;
        }
        public string ContractInfo
        {
            get => lblContract.Text;
            set => lblContract.Text = value;
        }
        public string Deposit
        {
            get => lblUnitType.Text;
            set => lblUnitType.Text = value;
        }
        public string UnitType
        {
            get => lblUnitType.Text;
            set => lblUnitType.Text = value;
        }
        public string TotalUtilities
        {
            get => lblTotal.Text;
            set => lblTotal.Text = value;
        }
        public string PaymentStatus
        {
            get => btnStatus.Text;
            set
            {
                string status = value;

                //check for overdue if status is unpaid
                if (status.ToLower() == "unpaid" && !string.IsNullOrEmpty(BillId))
                {
                    try
                    {
                        //query billing_month or due_date for this bill
                        string sql = $"SELECT billing_month FROM tbl_utilities WHERE bill_id = '{BillId}'";
                        DataTable dt = db.GetData(sql);
                        if (dt.Rows.Count > 0)
                        {
                            DateTime bm = DateTime.ParseExact(dt.Rows[0]["billing_month"].ToString(), "yyyy-MM", null);
                            DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

                            if (bm < now)
                            {
                                status = "overdue"; // 👈 override to overdue
                            }
                        }
                    }
                    catch {}
                }

                btnStatus.Text = status;

                if (status == "unpaid")
                {
                    btnStatus.FillColor = Color.Red;
                    btnStatus.ForeColor = Color.White;
                    btnPaid.Enabled = true;
                }
                else if (status == "paid")
                {
                    btnStatus.FillColor = Color.Green;
                    btnStatus.ForeColor = Color.White;
                    btnPaid.Enabled = false;
                }
                else if (status == "overdue")
                {
                    btnStatus.FillColor = Color.Orange;
                    btnStatus.ForeColor = Color.White;
                    btnPaid.Enabled = true;
                }
                else
                {
                    btnStatus.FillColor = Color.Gray;
                    btnStatus.ForeColor = Color.Black;
                    btnPaid.Enabled = true;
                }
            }
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void ContractCard_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
            saveFileDialog.FileName = TenantName.Replace(" ", "_") + "_Bill.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                doc.Open();

                Paragraph title = new Paragraph("Tenant Billing Statement");
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                doc.Add(new Paragraph("Date: " + DateTime.Now.ToShortDateString()));
                doc.Add(new Paragraph("\n"));

                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;

                table.AddCell("Tenant Name");
                table.AddCell(TenantName);

                table.AddCell("Contract Info");
                table.AddCell(ContractInfo);

                table.AddCell("Room");
                table.AddCell(Room);

                table.AddCell("Unit Type");
                table.AddCell(UnitType);

                table.AddCell("Total Balance");
                table.AddCell(TotalUtilities);

                table.AddCell("Payment Status");
                table.AddCell(PaymentStatus);

                doc.Add(table);
                doc.Close();

                MessageBox.Show("PDF exported successfully!");
            }
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(
                    "Are you sure you want to mark this bill as PAID?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string updateStatus = $"UPDATE tbl_utilities SET status = 'paid' WHERE bill_id = '{BillId}'";
                    db.executeSQL(updateStatus);

                    if (db.rowAffected > 0)
                    {
                        string insertPayment = $@"
                            INSERT INTO tbl_payments 
                            (bill_id, payment_date, amount_paid, payment_method, receipt_number)
                            VALUES
                            (
                                '{BillId}', 
                                NOW(), 
                                (SELECT ut.total_fees + u.monthly_rate
                                 FROM tbl_utilities ut
                                 JOIN tbl_contracts c ON ut.contract_id = c.contract_id
                                 JOIN tbl_units u ON c.unit_id = u.unit_id
                                 WHERE ut.bill_id = '{BillId}'),
                                'Cash', UUID()
                            )";
                        db.executeSQL(insertPayment);

                        PaymentStatus = "paid"; // updates UI
                        MessageBox.Show("Bill marked as PAID successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No bill was updated. Please check BillId.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
