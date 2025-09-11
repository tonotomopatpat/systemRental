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
    public partial class tenantsPage : UserControl
    {
        Class1 db = new Class1("localhost", "rentalSystem", "root", "manzano");
        public tenantsPage()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
