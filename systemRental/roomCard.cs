using Guna.UI2.WinForms;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class roomCard : UserControl
    {
        public roomCard()
        {
            InitializeComponent();
        }

        public string unitStatus
        {
            get => btnStatus.Text;
            set => btnStatus.Text = value;
        }

        public Guna2Button StatusButton
        {
            get => btnStatus;
        }

        public string unitNo
        {
            get => lblUnitNo.Text;
            set => lblUnitNo.Text = string.IsNullOrWhiteSpace(value) ? "Unit: N/A" : "Unit: " + value;
        }

        public string unitSize
        {
            get => lblUnitSize.Text;
            set => lblUnitSize.Text = string.IsNullOrWhiteSpace(value) ? "Unit Size: N/A" : "Unit Size: " + value;
        }

        public string unitType
        {
            get => lblUnitType.Text;
            set => lblUnitType.Text = string.IsNullOrWhiteSpace(value) ? "Unit Type: N/A" : "Unit type: " + value;
        }

        public string unitRate
        {
            get => lblUnitRate.Text;
            set => lblUnitRate.Text = string.IsNullOrWhiteSpace(value) ? "Rate: N/A" : "Unit Rate: " + value;
        }

        public string tenant
        {
            get => lblTenant.Text;
            set => lblTenant.Text = string.IsNullOrWhiteSpace(value) ? "Tenant: N/a" : "Tenant: " + value;
        }

        private void roomCard_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
