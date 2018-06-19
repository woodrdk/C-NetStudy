using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPW116Final
{
    class CustomerDB
    {
        private static string GetConnectionString()
        {
            return "Data Source=localhost;Initial Catalog=BookRegistration;Integrated Security=True";
        }

        public static List<Customer> GetAllCustomers()
        {

            //STEP 1: Establish Connection to server
            var dbCon = new System.Data.SqlClient.SqlConnection();
            dbCon.ConnectionString = GetConnectionString();

            //STEP 2: Create command object with sql query
            string query = @"SELECT CustomerID
                            , DateOfBirth
	                        , FirstName
	                        , LastName
                            , Title
                        FROM Customer";
            //SqlCommand selCmd = new SqlCommand();
            //selCmd.CommandText = query;
            //selCmd.Connection = dbCon;
            var selCmd = new SqlCommand(query, dbCon);

            //STEP 3: Open connection to DB
            dbCon.Open();

            //STEP 4: Execute query against database
            SqlDataReader rdr = selCmd.ExecuteReader();

            //STEP 5: Do something with the results
            List<Customer> Customers = new List<Customer>();
            while (rdr.Read())
            {
                //convert row to customer object
                Customer cust = new Customer
                {   CustomerId = Convert.ToInt32(rdr["CustomerId"]),
                    FirstName = rdr["FirstName"].ToString(),
                    LastName = rdr["LastName"].ToString(),
                    DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]),
                    Title = rdr["Title"].ToString()

                };
                Customers.Add(cust);
            }

            //STEP 6: Close Connection
            dbCon.Close();
            
            return Customers;
        }
        private static SqlConnection GetSqlConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GetConnectionString();
            return con;

            //return new SqlConnection(GetConnectionString());
        }

        public static bool AddCust(Customer s)
        {

            SqlConnection con = GetSqlConnection();

            string query = @"INSERT INTO Customer
                    (FirstName, LastName, DateOfBirth, Title)
                VALUES
                     (@FName, @LName, @Dob, @Title)";

            SqlCommand addCmd =
                new SqlCommand(query, con);
            //add parameters for query here...
           
            addCmd.Parameters
                .AddWithValue("@FName", s.FirstName);
            addCmd.Parameters
               .AddWithValue("@LName", s.LastName);
            addCmd.Parameters
                .AddWithValue("@Dob", s.DateOfBirth);
            addCmd.Parameters
                .AddWithValue("@Title", s.Title);

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
                //close connection regardless of
                //whether query actually worked or not
                con.Close();
            }

        }
    }
}
