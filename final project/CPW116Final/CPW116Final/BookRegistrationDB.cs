using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPW116Final
{
    class BookRegistrationDB
    {
        private static string GetConnectionString()
        {
            return "Data Source=localhost;Initial Catalog=BookRegistration;Integrated Security=True";
        }



        public static List<Registration> GetRegistered()
        {

            //STEP 1: Establish Connection to server
            var dbCon = new System.Data.SqlClient.SqlConnection();
            dbCon.ConnectionString = GetConnectionString();

            //STEP 2: Create command object with sql query
            string query = @"SELECT CustomerID
	                        , ISBN
	                        , RegDate
                            FROM Registration";
 
            var selCmd = new SqlCommand(query, dbCon);

            //STEP 3: Open connection to DB
            dbCon.Open();

            //STEP 4: Execute query against database
            SqlDataReader rdr = selCmd.ExecuteReader();

            //STEP 5: Do something with the results
            List<Registration> Registered = new List<Registration>();
            while (rdr.Read())
            {
                //convert row to customer object
                Registration reg = new Registration
                {
                    CustomerId = Convert.ToInt32(rdr["CustomerID"]),
                    ISBN = rdr["ISBN"].ToString(),
                    RegDate = Convert.ToDateTime(rdr["RegDate"])
                };
                Registered.Add(reg);
            }

            //STEP 6: Close Connection
            dbCon.Close();

            return Registered;
        }
        private static SqlConnection GetSqlConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GetConnectionString();
            return con;

            //return new SqlConnection(GetConnectionString());
        }

        public static bool addReg(Registration s)
        {

            SqlConnection con = GetSqlConnection();

            string query = @"INSERT INTO Registration
                    (CustomerId, ISBN, RegDate)
                VALUES
                     (@CustomerId, @ISBN,  @RegDate)";

            SqlCommand addCmd =
                new SqlCommand(query, con);
            //add parameters for query here...
            addCmd.Parameters
                .AddWithValue("@CustomerId", s.CustomerId);
            addCmd.Parameters
               .AddWithValue("@ISBN", s.ISBN);
            addCmd.Parameters
                .AddWithValue("@RegDate", s.RegDate);
     

            //open connection
            try
            {
                con.Open();

                //executed query
                int rows = addCmd.ExecuteNonQuery();

                //do something with results
                if (rows == 1)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error\n{ex.Message}");
                return false;
            }
            finally
            {
                con.Close();
            }

        }
    }
}
