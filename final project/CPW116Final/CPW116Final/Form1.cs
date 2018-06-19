using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPW116Final
{
    public partial class frmPrimary : Form
    {
        public frmPrimary()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer secondForm = new frmAddCustomer();
            secondForm.Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddBook thirdForm = new frmAddBook();
            thirdForm.Show();
        }

        private void frmPrimary_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to quit? ", "Do you want to quit? ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("Thank you for using the Book Registration");
            }
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSeeReg_Click(object sender, EventArgs e)
        {
            frmRegistered fourthForm = new frmRegistered();
            fourthForm.Show();
        }

        private void frmPrimary_Load(object sender, EventArgs e)
        {

        }
    }
}
