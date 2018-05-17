using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // dont have any course selected
            if (cboCourseList.SelectedIndex < 0)
            {
                // will empty it out
                lblCourseInfo.Text = string.Empty;
            }
            else
            {
                string selCourse = cboCourseList.SelectedItem as string;

                switch (selCourse)
                {
                    case "CPW 116":
                        lblCourseInfo.Text = ".Net programming";
                        break;
                    case "CPW 203":
                        lblCourseInfo.Text = "ADV Javascript";
                        break;
                    default:
                        lblCourseInfo.Text = "No Data Available";
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int currYear = DateTime.Today.Year;
            int endYear = currYear + 4;
            for (int years = currYear; years <= endYear; years++)
            {
                lstExpirationYear.Items.Add(years);
            }

            PopulateCourseList();
            PopulateStudentList();
        }

        /// <summary>
        /// Gets Students from database and populates them in the combobox
        /// </summary>
        private void PopulateStudentList()
        {
            lstStudents.Items.Clear();
            // populate listbox
            List<string> students = GetStudents();
            students.Sort();
            foreach (string stu in students)
            {
                lstStudents.Items.Add(stu);
            }
            if (cboCourseList.Items.Count >= 1)
            {
                cboCourseList.SelectedIndex = 0;
            }
        }

        private void PopulateCourseList()
        {
            cboCourseList.Items.Clear();
            cboCourseList.DropDownStyle = ComboBoxStyle.DropDownList;
            List<string> courses = GetCourses();
            courses.Sort();
            foreach (string course in courses)
            {
                cboCourseList.Items.Add(course);
            }
        }

        private List<string> GetStudents()
        {
            return new List<string>()
            {
                "John Doe", "Jane Doe", "Jim Jones"
            };
        }

        private List<string> GetCourses()
        {
            /*
            var courses = new List<string>();
            courses.Add("CPW 116");
            courses.Add("CPW 203");
            return courses;
            the prev 4 lines are the same as the next chunk of code
             */

            return new List<string>()
            {
                "CPW 116", "CPW 203", "CPW 143"
            };
        }

        private void refreshAllDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateCourseList();
            PopulateStudentList();
        }

        private void lblCourseInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
