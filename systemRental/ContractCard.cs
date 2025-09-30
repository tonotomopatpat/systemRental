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
                btnStatus.Text = value;

                if (value == "Un-paid")
                {
                    btnStatus.FillColor = Color.Red;       // background
                    btnStatus.ForeColor = Color.White;     // text color
                    btnPaid.Enabled = true;
                }
                else if (value == "Paid")
                {
                    btnStatus.FillColor = Color.Green;
                    btnStatus.ForeColor = Color.White;
                    btnPaid.Enabled = false;
                }
                else
                {
                    btnStatus.FillColor = Color.Gray;      // default fallback
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
                DialogResult dr = MessageBox.Show("Are you sure you want to mark this bill as PAID?",
                                                  "Confirmation", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string query = $"UPDATE tbl_utilities SET status = 'Paid' WHERE bill_id = '{BillId}'";
                    db.executeSQL(query);

                    if (db.rowAffected > 0)
                    {
                        PaymentStatus = "Paid"; // ✅ updates UI & disables button
                        MessageBox.Show("Bill marked as PAID successfully!",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No bill was updated. Please check BillId.",
                                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
