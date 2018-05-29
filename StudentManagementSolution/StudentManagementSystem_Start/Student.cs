using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_Start
{
    class Student
    {   // fully implemented property 
        // use fully implemented for when you need to validate 
        // private field, with public getter/setter
        private string studentID;
        private string firstName;

        public Student()
        {
            // default no args constructor
            // compiler will create this if no other constructors are present
        }

        public Student(string name, DateTime dob, string major)
        {
            this.FirstName = name;
            this.DateOfBirth = dob;
            this.Major = major;
        } 

        public string StudentID
        {
            get{
                return studentID;
            }
            set{
                studentID = value;
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // auto implemented property
        // compiler creates private backing field
        // and codes the one line get set
        public DateTime DateOfBirth { get; set; }
        public string Major { get; set; }

        public bool Register(string courseCode)
        {
            // We need database with courses before we implement this method
            throw new NotImplementedException("Register has not been implemented yet");
        }

        public void PayTuition(double payAmt)
        {   
            throw new NotImplementedException("Pay tuition Not implemented yet");
        }



        public string MyProperty
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

    }
}
