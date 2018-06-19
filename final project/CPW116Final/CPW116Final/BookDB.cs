using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPW116Final
{
    class BookDB
    {
        private static string GetConnectionString()
        {
            return "Data Source=localhost;Initial Catalog=BookRegistration;Integrated Security=True";
        }
    
        
        public static List<Book> GetAllBooks()
        {
       
            //STEP 1: Establish Connection to server
            var dbCon = new System.Data.SqlClient.SqlConnection();
            dbCon.ConnectionString = GetConnectionString();

            //STEP 2: Create command object with sql query
            string query = @"SELECT ISBN
	                        , Price
	                        , Title
                            FROM Book";
            //SqlCommand selCmd = new SqlCommand();
            //selCmd.CommandText = query;
            //selCmd.Connection = dbCon;
            var selCmd = new SqlCommand(query, dbCon);

            //STEP 3: Open connection to DB
            dbCon.Open();

            //STEP 4: Execute query against database
            SqlDataReader rdr = selCmd.ExecuteReader();

            //STEP 5: Do something with the results
            List<Book> Books = new List<Book>();
            while (rdr.Read())
            {
                //convert row to student object
                Book bk = new Book
                {
                    ISBN = rdr["ISBN"].ToString(),
                    Price =  Convert.ToDouble(rdr["Price"]),
                    Title = rdr["Title"].ToString()
                };
                Books.Add(bk);
            }

            //STEP 6: Close Connection
            dbCon.Close();

            return Books;
        }

        private static SqlConnection GetSqlConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GetConnectionString();
            return con;

            //return new SqlConnection(GetConnectionString());
        }

        public static bool AddBookNow(Book s)
        {

            SqlConnection con = GetSqlConnection();

            string query = @"INSERT INTO Book
                    (ISBN, Price, Title)
                VALUES
                     (@ISBN, @Price, @Title)";

            SqlCommand addCmd =
                new SqlCommand(query, con);
            //add parameters for query here...

            addCmd.Parameters
                .AddWithValue("@ISBN", s.ISBN);
            addCmd.Parameters
               .AddWithValue("@Price", s.Price);
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

                con.Close();
            }

        }
    }
}
