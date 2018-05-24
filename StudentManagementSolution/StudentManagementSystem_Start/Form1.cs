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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent addStuForm = new frmAddStudent();
            

            DialogResult res = addStuForm.ShowDialog();

            if (res == DialogResult.OK)
            {
                // 3 methods to get data from another form
                // string stuName = (string)addStuForm.Tag; // another way to do the same as next line \\
                // string stuName = addStuForm.StudentName; \\ another way to do the same as next line //
                string stuName = addStuForm.GetStudentName();

                lstStudentRoster.Items.Add(stuName); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
