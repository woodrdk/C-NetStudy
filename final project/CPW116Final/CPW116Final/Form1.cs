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
            secondForm.ShowDialog();
            populateNameBox();
            populateBookBox();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddBook thirdForm = new frmAddBook();
            thirdForm.ShowDialog();
            populateNameBox();
            populateBookBox();
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
            populateNameBox();
            populateBookBox();
        }

        private void btnRegisterBook_Click(object sender, EventArgs e)
        {
            Customer customerObject = (Customer)cbName.SelectedItem;
            Book bookIsbn = (Book)cbBook.SelectedItem;
            DateTime regDate = dateTimePicker1.Value; 

            //add all data to student object
            //METHOD 1: POPULATE OBJECT PROPERTY BY PROPERTY
            var Register = new Registration();
            Register.CustomerId = customerObject.CustomerId;
            Register.ISBN = bookIsbn.ISBN;
            Register.RegDate = regDate;


            if (BookRegistrationDB.addReg(Register))
            {
                MessageBox.Show("Registered!");

                this.Tag = customerObject;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Cannot register at this time!");
            }
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void populateNameBox() {
            List<Customer> custList = CustomerDB.GetAllCustomers();
            cbName.Items.Clear();
            foreach (Customer s in custList)
            {
                cbName.Items.Add(s);
            }
        }

        public void populateBookBox()
        {
            List<Book> bookList = BookDB.GetAllBooks();
            cbBook.Items.Clear();
            foreach (Book s in bookList)
            {
                cbBook.Items.Add(s);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
