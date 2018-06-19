using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW116Final
{
    class Book
    {
        //fully implemented property
        //private field, with public getter/setter
        private string _studentID;
        private string _firstName;

        public Book()
        {
            //DEFAULT NO-ARGS CONSTRUCTOR
            //COMPILER WILL CREATE THIS IF
            //NO OTHER CONSTRUCTORS ARE PRESENT
        }

        public Book(double ISBN, double Price,
                                string title)
        {
            this.ISBN = ISBN;
            this.Price = Price;
            this.title = title;
        }



        public double ISBN { get; private set; }
        public double Price { get; private set; }
        public string title { get; private set; }

        public override string ToString()
        {
            return $"{ISBN} : {Price} : {title}";
        }
    }
}
