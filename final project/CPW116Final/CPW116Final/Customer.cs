using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW116Final
{
    public class Customer
    {
        private DateTime dateOfBirth;
        private string firstName;
        private string lastName;
        private string title;

        public Customer()
        {
            //DEFAULT NO-ARGS CONSTRUCTOR
            //COMPILER WILL CREATE THIS IF
            //NO OTHER CONSTRUCTORS ARE PRESENT
        }

        public Customer(string firstName, string LastName, DateTime DateOfBirth, string title)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Title = title;
        }
        public int CustomerId
        {
            get;
            set;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime DateOfBirth {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public override string ToString()
        {
            return $"{LastName},{FirstName} ";
        }
    }
}
