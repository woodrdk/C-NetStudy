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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            var addStuForm =
                new frmAddStudent();

            DialogResult res =
                addStuForm.ShowDialog();

            if (res == DialogResult.OK)
            {
                PopulateStudentListBox();
                //3 methods to get data from another form
                //string stuName = (string)addStuForm.Tag;
                //string stuName = addStuForm.StudentName;
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
            List<Student> stuList =
                            StudentDB.GetAllStudents();

            lstStudentRoster.Items.Clear();
            foreach (Student s in stuList)
            {
                lstStudentRoster.Items.Add(s);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            //ensure a student is selected
            if (lstStudentRoster.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a student");
                return;
            }

            DialogResult res = MessageBox
                .Show("Are you sure?",
                        string.Empty,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                //get selected student
                Student selStu =
                    lstStudentRoster.SelectedItem as Student;

                //delete student by SID
                if (StudentDB.DeleteStudent(selStu.StudentID))
                {
                    MessageBox.Show($"{selStu.FirstName} was deleted");
                    //PopulateStudentListBox();

                    //This removes the student from the listbox
                    //and is more efficient then talking to DB again
                    lstStudentRoster.Items.Remove(selStu);
                }
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            //make sure there is a student selected

            //get the selected student object
            Student s = 
                lstStudentRoster.SelectedItem as Student;

            //open the Update form
            frmUpdateStudent frmUpdate =
                new frmUpdateStudent(s);
            frmUpdate.ShowDialog();
            //after update form is closed
            PopulateStudentListBox();
        }
    }
}
