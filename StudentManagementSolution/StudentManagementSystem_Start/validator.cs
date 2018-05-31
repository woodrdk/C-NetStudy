using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// manually type it in 
using System.Windows.Forms;

namespace StudentManagementSystem_Start
{   
    /// <summary>
    /// Provides validation methods for Windows Forms applications
    /// </summary>
    static class validator
    {   
        /// <summary>
        /// Checks that the text box contains something besides whitespace
        /// </summary>
        /// <param name="box">The textbox used for validation</param>
        /// <returns>Returns true if textbox contains some text, false if null or only whitespace</returns>
        public static bool DoesTextBoxContainText(TextBox box) 
        {
            if (TextBox == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(TextBox.Text))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numToCheck"></param>
        /// <param name="minValue">The inclusive minimum</param>
        /// <param name="maxValue">The inclusive maximum</param>
        /// <returns></returns>
        public static bool IsWithinRange(double numToCheck, double minValue, double maxValue)
        {
            if (numToCheck >= minValue && numToCheck <= maxValue)
            {
                return true;
            }
            return false;

            // another way to write this method 
            // return numToCheck >= minValue && numToCheck <= maxValue;
        }
    }
}
