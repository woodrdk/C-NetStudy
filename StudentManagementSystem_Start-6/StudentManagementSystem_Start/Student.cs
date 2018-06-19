using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_Start
{
    public class Student
    {
        //fully implemented property
        //private field, with public getter/setter
        private string _studentID;
        private string _firstName;

        public Student()
        {
            //DEFAULT NO-ARGS CONSTRUCTOR
            //COMPILER WILL CREATE THIS IF
            //NO OTHER CONSTRUCTORS ARE PRESENT
        }

        public Student(string name, DateTime dob,
                                string major)
        {
            this.FirstName = name;
            this.DateOfBirth = dob;
            this.Major = major;
        }

        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        //AUTO-Implemented Property
        //Compiler creates private backing field
        //AND codes the one line get/set
        public DateTime DateOfBirth { get; set; }

        public string Major { get; set; }

        public bool Register(string courseCode)
        {
            //We need a database with courses before
            //we implement this method
            throw new NotImplementedException();
        }

        public void PayTuition(double payAmt)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{StudentID} : {FirstName}";
        }
    }
}
