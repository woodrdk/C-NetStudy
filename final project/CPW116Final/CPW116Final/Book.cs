using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW116Final
{
    class Book
    {
     
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


        public string title {
            get { return title; }
            set { title = value; }
        }
        public double ISBN
        {
            get { return ISBN; }
            set { ISBN = value; }
        }
        public double Price {
            get { return Price;}
            set { Price = value; }
        }
 

        public override string ToString()
        {
            return $"{ISBN} : {Price} : {title}";
        }
    }
}
