using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_Start
{
    static class StudentDB
    {
        private static string GetConnectionString()
        {
            return "Data Source=localhost;Initial Catalog=SMS;Integrated Security=True";
        }

        public static List<Student> GetAllStudents()
        {
            //string con = GetConnectionString();
            //var dbCon = new SqlConnection(con);

            //var dbCon = 
            //    new SqlConnection(GetConnectionString());

            //STEP 1: Establish Connection to server
            var dbCon = new SqlConnection();
            dbCon.ConnectionString = GetConnectionString();

            //STEP 2: Create command object with sql query
            string query = @"SELECT SID
	                        , FirstName
	                        , DateOfBirth
	                        , Major
                           FROM Students";
            //SqlCommand selCmd = new SqlCommand();
            //selCmd.CommandText = query;
            //selCmd.Connection = dbCon;
            var selCmd = new SqlCommand(query, dbCon);

            //STEP 3: Open connection to DB
            dbCon.Open();

            //STEP 4: Execute query against database
            SqlDataReader rdr = selCmd.ExecuteReader();

            //STEP 5: Do something with the results
            List<Student> students = new List<Student>();
            while (rdr.Read())
            {
                //convert row to student object
                Student stu = new Student
                {
                    StudentID = rdr["SID"].ToString(),
                    FirstName = (string)rdr["FirstName"],
                    DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]),
                    Major = Convert.ToString(rdr["Major"])
                };
                students.Add(stu);
            }

            //STEP 6: Close Connection
            dbCon.Close();
            //dbCon.Dispose(); //(calls close internally)

            return students;
        }

        public static bool DeleteStudent(string sid)
        {
            SqlConnection con = GetSqlConnection();

            string query = "DELETE FROM Students " +
                "WHERE SID = @sid";

            SqlCommand delCmd =
                new SqlCommand(query, con);
            delCmd.Parameters.AddWithValue("@sid", sid);

            con.Open();

            int rowsAffected = delCmd.ExecuteNonQuery();

            con.Close();
            if (rowsAffected == 1)
                return true;
            else
                return false;
        }

        public static bool DeleteStudent(Student s)
        {
            throw new NotImplementedException();
        }

        private static SqlConnection GetSqlConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GetConnectionString();
            return con;

            //return new SqlConnection(GetConnectionString());
        }

        public static bool AddStudent(Student s)
        {
            
            SqlConnection con = GetSqlConnection();

            string query = @"INSERT INTO Students
                    (SID, FirstName, DateOfBirth, Major)
                VALUES
                     (@Sid, @FName, @Dob, @Major)";

            SqlCommand addCmd =
                new SqlCommand(query, con);
            //add parameters for query here...
            addCmd.Parameters
                .AddWithValue("@SID", s.StudentID);
            addCmd.Parameters
                .AddWithValue("@FName", s.FirstName);
            addCmd.Parameters
                .AddWithValue("@Dob", s.DateOfBirth);
            addCmd.Parameters
                .AddWithValue("@Major", s.Major);

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
            catch(SqlException ex)
            {
                MessageBox
                 .Show($"Database error\n{ex.Message}");
                return false;
            }
            finally
            {
                //close connection regardless of
                //whether query actually worked or not
                con.Close();
            }

        }

        public static bool UpdateStudent(Student s)
        {
            SqlConnection con = GetSqlConnection();

            string query = "UPDATE Students " +
                            "SET FirstName = @fName, " +
                            "DateOfBirth = @dob, " +
                            "Major = @major " +
                            "WHERE SID = @sid";
            SqlCommand updateCmd =
                new SqlCommand(query, con);
            //add parameters
            updateCmd.Parameters
                .AddWithValue("@fName", s.FirstName);
            updateCmd.Parameters
                .AddWithValue("@dob", s.DateOfBirth);
            updateCmd.Parameters
                .AddWithValue("@major", s.Major);
            updateCmd.Parameters
                .AddWithValue("@sid", s.StudentID);

            con.Open();

            int rowsAffected = 
                updateCmd.ExecuteNonQuery();

            con.Close();

            if (rowsAffected == 1)
                return true;
            return false;
        }
    }
}
