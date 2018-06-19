using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_Start
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());

            //Student s1 = new Student();
            //s1.FirstName = "Joe";
            //s1.StudentID = "9675464";
            //s1.DateOfBirth = DateTime.Today;

            //string fName = s1.FirstName;
            //DateTime dob = s1.DateOfBirth;
            //var s2 = new Student();
            //var s3 = new Student();

            //List<Student> classRoster =
            //    new List<Student>();
            //foreach(Student stu in classRoster)
            //{
            //    Console.WriteLine(stu.FirstName);
            //}

            //classRoster[0].FirstName = "First Stu";
        }
    }
}
