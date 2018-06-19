using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_Start
{
    /// <summary>
    /// Provides validation methods for Windows Forms
    /// applications
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Checks that the textbox contains something
        /// besides whitespace
        /// </summary>
        /// <param name="textBox">The textbox used for validation</param>
        /// <returns>Returns true if textbox contains some text, false if null or only whitespace</returns>
        public static bool DoesTextBoxContainText(TextBox textBox)
        {
            if (textBox == null || 
                string.IsNullOrWhiteSpace(textBox.Text))
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
            return numToCheck >= minValue &&
                numToCheck <= maxValue;

            //if(numToCheck >= minValue &&
            //    numToCheck <= maxValue)
            //{
            //    return true;
            //}

            //return false;
        }
    }
}
