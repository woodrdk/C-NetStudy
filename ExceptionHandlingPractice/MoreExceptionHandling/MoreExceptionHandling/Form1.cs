using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreExceptionHandling
{
    public partial class frmMoreException : Form
    {
        public frmMoreException()
        {
            InitializeComponent();
            error.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }
        ErrorProvider error = new ErrorProvider();

        /// <summary>
        /// Checks if textbox contains non white space character data
        /// </summary>
        /// <param name="box">text box to validate</param>
        /// <returns>returns true if text box contains non white space character  data</returns>
        private bool DoesTextBoxContainData(TextBox box)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
                return false;
            return true;

            /*
             * 
             * return box.Text != null & box.text.trim() != string.Empty;
             * 
             * if (box.Text == null || box.Text.Trim() == string.Empty)
             * {
             *     return false;
             * }
             * return true;
             * 
            */
        }
        /// <summary>
        /// Checks if textbox contains character data & displays error if no data is present
        /// </summary>
        /// <param name="box">The textbox to validate</param>
        /// <param name="nameOfTextBox">Human readable name of text box to display in error message</param>
        /// <returns>Returns true if contains any character data</returns>
        /// 
        private bool DoesTextBoxContainData(TextBox box, string nameOfTextBox)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                
                error.SetError(txtFirstName, $"{nameOfTextBox} does not contain data");

                // MessageBox.Show($"{nameOfTextBox} does not contain data");
                return false;
            }
            return true;
        }

        private void frmMoreException_Load(object sender, EventArgs e)
        {
            
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ResetTextBoxErrors();

            //string allErrors = string.Empty;
            //if(!DoesTextBoxContainData(txtFirstName))
            //{
            //    allErrors += "first name is required !\n";
            //}
            // check all validation 

            // validate data
            if (DoesTextBoxContainData(txtFirstName, "First Name") & DoesTextBoxContainInt32(txtAge, "Age"))
            {
                // add data to database 
                MessageBox.Show("data added");
            }
        }

        private void ResetTextBoxErrors()
        {
            //// remove error
            //error.SetError(txtFirstName, null);
            //error.SetError(txtAge, null);

            //  advanced technique for clearing all errors
            // finds all child controls of the form
            foreach (Control c in this.Controls)
            {
                // check if control is a Textbox
                if(c is TextBox)
                {
                    // clear the error on that textbox
                    error.SetError(c, null);
                }
            }
        }

        private bool DoesTextBoxContainInt32(TextBox box, string name)
        {
            if (DoesTextBoxContainData(box))
            {
                try
                {
                    Convert.ToInt32(box.Text);
                    return true;
                }
                catch
                {
                    error.SetError(txtAge, $"{name} must be a number!");
                    return false;
                }
            }
            error.SetError(txtAge, $"{name} is required");
            return false;

        }
    }
}
