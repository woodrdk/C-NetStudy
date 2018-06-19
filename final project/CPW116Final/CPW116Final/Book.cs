using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW116Final
{
    public class Book
    {
        private string isbn;
        private double price;
        private string title;

        public Book()
        {
            //DEFAULT NO-ARGS CONSTRUCTOR
            //COMPILER WILL CREATE THIS IF
            //NO OTHER CONSTRUCTORS ARE PRESENT
        }

        public Book(string isbn, double price,
                                string title)
        {
            this.ISBN = isbn;
            this.Price = price;
            this.Title = title;
        }


        public string Title {
            get { return title; }
            set { title = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public double Price {
            get { return price;}
            set { price = value; }
        }
 

        public override string ToString()
        {
            return $" {title}";
        }
    }
}
