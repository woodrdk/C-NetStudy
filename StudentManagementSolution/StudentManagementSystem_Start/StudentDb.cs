using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_Start
{
    static class StudentDb
    {
        private static string GetConnectionString() {
            return "Data Source = localHost; Initial Catalog = SMS; Integrated Security = True";
        }
        
        public static List<Student> GetAllStudents()
        {
            // string con = GetConnectionString();
            // var dbConSqlConnection = new SqlConnection(con);
            // or

            // var dbCon = new SqlConnection(GetConnectionString());
            // or

            // Step 1 - Establish connection to server
            var dbCon = new SqlConnection();
            dbCon.ConnectionString = GetConnectionString();

            // Step 2 - Create command object with sql query
            string query = @"SELECT SID
                            , FirstName
                            , DateOfBirth
                            , Major 
                            FROM Students";
            // SqlCommand selCmd = new SqlCommand();
            // selCmd.CommandText = query;
            // selCmd.Connection = dbCon;
            // or
            SqlCommand selCmd = new SqlCommand
            {
                CommandText = query,
                Connection = dbCon
            };
            // or the prev three lines can be written like this
            // var selCmd = new SqlCommand(query, dbCon);

            // Step 3 - Open connection to DB
            dbCon.Open();

            // Step 4 - Execute query against database
            SqlDataReader rdr = selCmd.ExecuteReader();

            // Step 5 - Do something with the results
            List<Student> students = new List<Student>();
            while (rdr.Read())
            {
                // convert row to student object
                Student stu = new Student();
                // stu.StudentID = rdr[0]; 
                // or do this
                stu.StudentID = rdr["SID"].ToString();
                stu.FirstName = rdr["FirstName"].ToString();
                // stu.DateOfBirth = (DateTime)rdr["DateOfBirth"]; or do this like the next line
                stu.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);
                stu.Major = rdr["Major"].ToString();
                // or stu.Major = Convert.ToString(rdr["Major"]);

                students.Add(stu);
            }

            // Step 6 - Close connection
            dbCon.Close();
            // or
            // dbCon.Dispose(); // calls close internally

            return students;
        }

        public static bool DeleteStudent(string sid)
        {
            SqlConnection con = GetSQLConnection();

            string query = "DELETE FROM Students" +
                " WHERE SID = @sid";

            SqlCommand delCmd = new SqlCommand(query, con);
            delCmd.Parameters.AddWithValue("@sid", sid);
            
            con.Open();

            int rowsAffected = delCmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

            

        }

        public static bool DeleteStudent(Student s)
        {
            throw new NotImplementedException();
           
        }

        private static SqlConnection GetSQLConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GetConnectionString();
            return con;
        }

        public static bool AddStudent(Student s)
        {
            SqlConnection con = GetSQLConnection();
            string query = @"INSERT INTO Students
            (SID, FirstName, DateOfBirth, Major)
            Values
            (@Sid, @FirstName, @DateOfBirth, @Major)";
            SqlCommand addCmd = new SqlCommand(query, con);
            
            // add parameters for query here.....
            addCmd.Parameters.AddWithValue("@Sid", s.StudentID);
            addCmd.Parameters.AddWithValue("@FirstName", s.FirstName);
            addCmd.Parameters.AddWithValue("@DateOfBirth", s.DateOfBirth);
            addCmd.Parameters.AddWithValue("@Major", s.Major);
            
            // open connection
            try
            {
                con.Open();

                // executed query
                int rows = addCmd.ExecuteNonQuery();

                // do something with results
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
                // close connection no matter if query worked or not
                con.Close();
                // or con.dispose()
            }
         

        }

        public static bool UpdateStudent(Student s)
        {
            throw new NotImplementedException();
            
        }

        // example of lambda usage
        //public static double Multiply(int a) { return a * 2; }
        //public static double Multiply(int a) => a * 2;
    }
}
