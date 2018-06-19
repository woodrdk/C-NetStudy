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
            var addBook();
            addBook.FirstName = firstName;
            addBook.DateOfBirth = dob;
            addBook.Price;
            addBook.lastName = lastName;
            ////database will generate SID
            ////METHOD 2: Object Initialization Syntax
 
            //add student object to database
            if (StudentDB.AddStudent(addStu))
            {
                MessageBox.Show("Student Added!");

                //ignore passing the name back to the 
                //main form
                this.Tag = name;
                this.StudentName = name;
                this.stu = name;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
