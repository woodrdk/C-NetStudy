using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW116Final
{
    class DBHelper
    {
        public static SqlConnection GetSQLConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog=BookRegistration;Integrated Security=True";
            return con;
        }
    }
}
