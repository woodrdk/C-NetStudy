using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW116Final
{
    class BookDB
    {
        private static string GetConnectionString()
        {
            return "Data Source=localhost;Initial Catalog=SMS;Integrated Security=True";
        }

        public static List<Book> GetAllBooks()
        {
       
            //STEP 1: Establish Connection to server
            var dbCon = new System.Data.SqlClient.SqlConnection();
            dbCon.ConnectionString = GetConnectionString();

            //STEP 2: Create command object with sql query
            string query = @"SELECT ISBN
	                        , Price
	                        , Title";
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
                    ISBN = Convert.ToDouble(rdr["ISBN"]),
                    Price =  Convert.ToDouble(rdr["Price"]),
                    title = rdr["Title"].ToString(),
         
                };
                Books.Add(bk);
            }

            //STEP 6: Close Connection
            dbCon.Close();
            //dbCon.Dispose(); //(calls close internally)

            return Books;
        }
    }
}
