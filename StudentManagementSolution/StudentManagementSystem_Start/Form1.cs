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
            var addStuForm = new frmAddStudent();
            

            DialogResult res = addStuForm.ShowDialog();

            if (res == DialogResult.OK)
            {
                PopulateStudentListBox();
                // 3 methods to get data from another form
                // string stuName = (string)addStuForm.Tag; // another way to do the same as next line \\
                // string stuName = addStuForm.StudentName; \\ another way to do the same as next line //
                //string stuName = addStuForm.GetStudentName();
                //lstStudentRoster.Items.Add(stuName); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateStudentListBox();
        }

        private void PopulateStudentListBox()
        {
            List<Student> stuList = StudentDb.GetAllStudents();
            lstStudentRoster.Items.Clear();
            foreach (Student s in stuList)
            {
                lstStudentRoster.Items.Add(s);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            // ensure a student is selected
            if(lstStudentRoster.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a student");
                return;
            }
            // get selected student
            Student selStu = lstStudentRoster.SelectedItem as Student;

            // delete student by sid
            if (StudentDb.DeleteStudent(selStu.StudentID))
            {
                MessageBox.Show($"{ selStu.FirstName} was deleted");
                // PopulateStudentListBox();
                // or do this lstStudentRoster.Items.Remove(selStu); this removes just the student and is more effecient 
                // than talking to database
                lstStudentRoster.Items.Remove(selStu);
            }
            else {
                MessageBox.Show("Student could not be deleted at this time");
            }
        }
    }
}
