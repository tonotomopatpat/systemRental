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
    public partial class addroom : Form
    {
        public addroom()
        {
            InitializeComponent();
        }

        Class1 db = new Class1("localhost", "rentalSystem", "root", "manzano");
        //event for reloading the roomPage
        
        private void btnDone_Click(object sender, EventArgs e)
        {
            int errorcount = 0;

            //validation
            if (string.IsNullOrWhiteSpace(txtUnitNumber.Text))
            {
                MessageBox.Show("Unit number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorcount++;
            }
            if (string.IsNullOrWhiteSpace(txtFloor.Text))
            {
                MessageBox.Show("Floor is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorcount++;
            }
            if (string.IsNullOrWhiteSpace(txtSize.Text))
            {
                MessageBox.Show("Size is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorcount++;
            }
            if (string.IsNullOrWhiteSpace(cmbUnitType.Text))
            {
                MessageBox.Show("Unit type is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorcount++;
            }
            if (string.IsNullOrWhiteSpace(txtMonthlyRate.Text))
            {
                MessageBox.Show("Monthly rate is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorcount++;
            }

            if (errorcount > 0) return;
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to save this tenant and contract?",
                                           "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string insertRoom = "INSERT INTO tbl_units " +
                "(unit_number, floor, size, unit_type, monthly_rate, status) VALUES (" +
                $"'{txtUnitNumber.Text}', '{txtFloor.Text}', '{txtSize.Text}', " +
                $"'{cmbUnitType.SelectedItem.ToString()}', '{txtMonthlyRate.Text}', 'vacant')";

                    db.executeSQL(insertRoom);

                    if (db.rowAffected > 0)
                    {
                        MessageBox.Show("Room saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error inserting room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
