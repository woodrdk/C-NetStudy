using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementWithList
{
    public partial class frmStudentManagement : Form
    {

        private List<string> students = new List<string>();
        public frmStudentManagement()
        {
            InitializeComponent();
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Please enter a name!");
 
            }
            else
            {
                students.Add(txtStudentName.Text.Trim());
                MessageBox.Show("student added");
            }
            txtStudentName.Clear();
            txtStudentName.Focus();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("no students");
                return;
            }

            string display = string.Join("\n", students);
            MessageBox.Show(display);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            students.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();
            string searchTerm = txtSearch.Text.Trim().ToLower();
            searchTerm = searchTerm.Trim();

            if (searchTerm == string.Empty)
            {
                return;
            }

            foreach (string stu in students)
            {
                if(stu.ToLower().Contains(searchTerm))
                {
                    lstStudents.Items.Add(stu);
                }
            }
        }
    }
}
