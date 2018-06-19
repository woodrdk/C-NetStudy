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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDOB.Clear();
            txtFirst.Clear();
            txtLast.Clear();
            txtTitle.Clear();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            string firstName = txtFirst.Text;
            string lastName = txtLast.Text;
            DateTime dob = Convert.ToDateTime(txtDOB.Text);
            string title = txtTitle.Text;

            //add all data to student object
            //METHOD 1: POPULATE OBJECT PROPERTY BY PROPERTY
            var addCustomer = new Customer();
            addCustomer.FirstName = firstName;
            addCustomer.LastName = lastName;
            addCustomer.DateOfBirth = dob;
            addCustomer.Title = title;

            txtDOB.Clear();
            txtFirst.Clear();
            txtLast.Clear();
            txtTitle.Clear();

            

            if (CustomerDB.AddCust(addCustomer))
            {
                MessageBox.Show("Customer Added!");

                this.Tag = firstName;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Customer cannot be added at this time!");
            }
            
        }
        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
    
   
        
}

