using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_Start
{
    static class StudentDb
    {
        private static string GetConnectionString() {
            return "Data Source = B11R111E - 11; Initial Catalog = SMS; Integrated Security = True";
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
            // Step 3 - Open connection to DB
            // Step 4 - Execute query against database
            // Step 5 - Do something with the results
            // Step 6 - Close connection
        }

        public static bool DeleteStudent(string sid)
        {
            throw new NotImplementedException();
            // var dbCon = new SqlConnection(GetConnectionString());
        }

        public static bool DeleteStudent(Student s)
        {
            throw new NotImplementedException();
            // var dbCon = new SqlConnection(GetConnectionString());
        }

        public static bool AddStudent(Student s)
        {
            throw new NotImplementedException();
            // var dbCon = new SqlConnection(GetConnectionString());
        }

        public static bool UpdateStudent(Student s)
        {
            throw new NotImplementedException();
            // var dbCon = new SqlConnection(GetConnectionString());
        }

        // example of lambda usage
        //public static double Multiply(int a) { return a * 2; }
        //public static double Multiply(int a) => a * 2;
    }
}
