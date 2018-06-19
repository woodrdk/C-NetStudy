using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW116Final
{
    class DBHelper
    {
        private static string GetConnectionString()
        {
            return "Data Source=localhost;Initial Catalog=BookRegistration;Integrated Security=True";
        }
    }
}
