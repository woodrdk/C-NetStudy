using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandlingPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                int length =
                    Convert.ToInt32(txtLength.Text);
                int width =
                    Convert.ToInt32(txtWidth.Text);
                int area = length * width;
                int perimeter = length * 2 + width * 2;
                MessageBox.Show($"Area: {area}\nPerimeter: {perimeter}");
            }

        }

        private bool IsFormValid()
        {
            bool isDataValid = true;

            //check Area is valid
            if (!IsPresent(txtLength) ||
                !IsInt32(txtLength.Text))
            {
                MessageBox.Show("Area must be a whole number and is required!");
                isDataValid = false;
            }
            else if (!IsWithinRange(Convert.ToInt32(txtLength.Text), 0, 10000))
            {
                isDataValid = false;
                MessageBox.Show("Area must be between 0 and 10,000");
            }

            if (!IsPresent(txtWidth) ||
                !IsInt32(txtWidth.Text))
            {
                isDataValid = false;
                MessageBox.Show("Perimeter is required and must be a number!");
            }

            return isDataValid;
        }

        /// <summary>
        /// Checks to make sure a number is within
        /// inclusive bounds
        /// </summary>
        /// <param name="numToCheck">The number to check is within range</param>
        /// <param name="minValue">The inclusive lower bound</param>
        /// <param name="maxValue">The inclusive upper bound</param>
        /// <returns></returns>
        private bool IsWithinRange(double numToCheck,
                                    double minValue,
                                    double maxValue)
        {
            if (numToCheck >= minValue
                && numToCheck <= maxValue)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks to make sure that the string
        /// is a valid Int32
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private bool IsInt32(string data)
        {
            try
            {
                Convert.ToInt32(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Makes sure that there is some text
        /// in a textbox. Whitespace is not counted
        /// </summary>
        /// <param name="box">The textbox to be checked</param>
        /// <returns></returns>
        private bool IsPresent(TextBox box)
        {
            //make sure there is a textbox to check
            if (box == null)
                return false;

            //make sure there is text and it's not
            //whitespace or empty string
            if (string.IsNullOrWhiteSpace(box.Text))
                return false;

            return true;
        }

        private void btnValidateSsn_Click(object sender, EventArgs e)
        {
            if (IsPresent(txtSsn) &&
                IsValidSocialNum(txtSsn.Text))
            {

                MessageBox.Show("SSN is good!");

            }
        }

        private bool IsValidSocialNum(string input)
        {
            Regex reg =
                new Regex(@"^\d{3}-?\d{2}-?\d{4}$");
            if (reg.IsMatch(input))
            {
                return true;
            }
            return false;
        }
    }
}
