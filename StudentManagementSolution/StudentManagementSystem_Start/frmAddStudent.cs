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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        public string StudentName { get; set; } // if not public will not communicate with form1, public gives it permission

        private string stu;

        public string GetStudentName()
        {
            return stu;
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // if data is valid
            string name = txtName.Text;

            // add all data to student object

            // add student object to database

            // if added to database

            // store data in Tag property to access on main form
            this.Tag = name;
            this.StudentName = name;
            this.stu = name;

            this.DialogResult = DialogResult.OK;


        }
    }
}
