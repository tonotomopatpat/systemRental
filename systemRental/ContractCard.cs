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
    public partial class ContractCard : UserControl
    {
        public ContractCard()
        {
            InitializeComponent();
        }

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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
