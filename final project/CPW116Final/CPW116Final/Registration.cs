using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW116Final
{

    public class Registration
    {
        private int customerId;
        private string isbn;
        private DateTime regDate;

        public Registration() { }

        public Registration(int customerId, string isbn,  DateTime regDate)
        {
            this.customerId = customerId;
            this.isbn = isbn;
            this.regDate = regDate;
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public DateTime RegDate
        {
            get { return regDate; }
            set { regDate = value; }
        }

        public override string ToString()
        {
            return $"{CustomerId} : {ISBN} : {RegDate}";
        }
    }
}
