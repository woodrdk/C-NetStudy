using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_Start
{
    class Student
    {   // fully implemented property 
        // private field, with public getter/setter
        private string studentID;
        public string StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;

            }
        }

        private string FirstName;

        public string MyProperty
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

    }
}
