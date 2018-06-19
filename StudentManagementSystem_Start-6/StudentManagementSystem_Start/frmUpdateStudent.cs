using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_Start
{
    public partial class frmUpdateStudent : Form
    {
        private Student stu;

        public frmUpdateStudent(Student stu)
        {
            InitializeComponent();
            this.stu = stu;
        }

        private void frmUpdateStudent_Load(object sender, EventArgs e)
        {
            txtStudentID.Enabled = false;

            //populate form with existing stu data
            txtStudentID.Text = stu.StudentID;
            txtName.Text = stu.FirstName;
            txtMajor.Text = stu.Major;
            txtDateOfBirth.Text =
                stu.DateOfBirth.ToShortDateString();

        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            //update student with new data
            stu.FirstName = txtName.Text;
            stu.Major = txtMajor.Text;
            stu.DateOfBirth = 
                Convert.ToDateTime(txtDateOfBirth.Text);

            if (StudentDB.UpdateStudent(stu))
            {
                MessageBox.Show("Updated!");
                Close();
            }
        }
    }
}
