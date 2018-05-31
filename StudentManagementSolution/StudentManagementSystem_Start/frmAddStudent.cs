﻿using System;
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
            if (IsDataValid())
            {
                string name = txtName.Text;
                DateTime dob = Convert.ToDateTime(txtDOB.Text);
                string major = txtMajor.Text;

                // add all data to student object
                // Method 1: populate object property by property
                var addStu = new Student();
                addStu.FirstName = name;
                addStu.DateOfBirth = dob;
                addStu.Major = major;
                // database will generate SID

                // method 2: pbject initialization syntax
                var addStu2 = new Student()
                {
                    FirstName = name,
                    DateOfBirth = dob,
                    Major = major
                };

                // method 3: use the constructor
                var addstu3 = new Student(name, dob, major);

                // add student object to database

                // if added to database

                // store data in Tag property to access on main form
                this.Tag = name;
                this.StudentName = name;
                this.stu = name;

                this.DialogResult = DialogResult.OK;
            }
        }

        private bool IsDataValid()
        {
            // implement validation in version 2.0
            return true;
        }
    }
}