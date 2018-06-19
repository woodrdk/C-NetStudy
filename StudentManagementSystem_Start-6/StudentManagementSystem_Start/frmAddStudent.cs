using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentManagementSystem_Start.Validator;

namespace StudentManagementSystem_Start
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        public string StudentName { get; set; }

        private string stu;

        public string GetStudentName()
        {
            return stu;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if(IsDataValid())
            {
                string name = txtName.Text;
                DateTime dob = Convert.ToDateTime(txtDateOfBirth.Text);
                string major = txtMajor.Text;

                //add all data to student object
                //METHOD 1: POPULATE OBJECT PROPERTY BY PROPERTY
                var addStu = new Student();
                addStu.FirstName = name;
                addStu.DateOfBirth = dob;
                addStu.Major = major;
                addStu.StudentID = txtStudentID.Text;
                ////database will generate SID
                ////METHOD 2: Object Initialization Syntax
                //var addStu2 = new Student()
                //{
                //    FirstName = name,
                //    DateOfBirth = dob,
                //    Major = major
                //};

                //METHOD 3: Use the constructor!
                //var addStu3 =
                //    new Student(name, dob, major);

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
                else
                {
                    MessageBox.Show("Stu cannot be added at this time!");
                }
                
            }
        }

        private bool IsDataValid()
        {
            bool isValid = true;

            if (!Validator
                .DoesTextBoxContainText(txtName))
            {
                MessageBox.Show("Name must have data!");
                isValid = false;
            }
            if (!DoesTextBoxContainText(txtMajor))
            {
                isValid = false;
            }

            return isValid;
        }

        private bool AreAllTextboxesValid()
        {
            bool isValid = true;

            //loop through every control on form
            foreach(Control c in Controls)
            {
                if(c is TextBox)
                {
                    TextBox currBox = c as TextBox;
                    if (currBox.ReadOnly)
                    {
                        continue;
                    }
                    if (!Validator.DoesTextBoxContainText(currBox))
                    {
                        MessageBox.Show($"{currBox.Tag} is required!");
                        isValid = false;
                    }
                }
            }
            return isValid;
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
