using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exception_handling_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                byte age = Convert.ToByte(txtAge.Text);
                if (age > 0 && age <= 130)
                    MessageBox.Show($" Thanks for entering {age}");
                else
                    //MessageBox.Show("You should be between 1 and 130");
                    throw new InvalidAgeException("You must be between 1 and 130");
            }
            catch (InvalidAgeException invalidAgeEx)
            {
                MessageBox.Show(invalidAgeEx.Message);
            }
            catch(FormatException fe)
            {
                // next line is user friendly release version exception
                MessageBox.Show("Please enter a valid number");
#if DEBUG
                // type of exception
                MessageBox.Show(fe.GetType().ToString());
                MessageBox.Show(fe.Message);
                MessageBox.Show(fe.StackTrace);
#endif
            }
            catch(OverflowException oe)
            {
                MessageBox.Show($"You must enter a number between {Byte.MinValue} and {Byte.MaxValue}");
            }
            finally
            {
                // In your finally you would typically
                // - close any open file connections
                // - close any open database connections
                // - close any unmanaged resources
                // put code that always runs
                // exception thrown or not
                MessageBox.Show("Finally block wa triggered");
            }
        }
        private bool DoesTextboxContainNumber(TextBox box)
        {
            try
            {
                Convert.ToDouble(box.Text);
                return true;
            }
            catch(Exception ex)
            {
                // handle the exceptiom
                // log the error infoMessageBox.Show($"{ box.Name} does not contain a number");
                throw ex;
            }
            try
            {
                Convert.ToDouble(box.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
