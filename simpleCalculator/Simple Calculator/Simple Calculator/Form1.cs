using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class frmSimpleCalculator : Form
    {
        private TextBox lastFocused;
        private void frmSimpleCalculator_Load(object sender, EventArgs e)
        {
            foreach (TextBox box in new TextBox[] { txtOperand1, txtOperand2 })
            {
                box.LostFocus += textBoxFocusLost;
            }
        }
        public frmSimpleCalculator()
        {
            InitializeComponent();
            error.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }
        ErrorProvider error = new ErrorProvider();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmSimpleCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to quit? ", "Do you want to quit? ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("Thank you for using this calculator");
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ResetTextBoxErrors();
            
            // validate data
            if (DoesTextBoxContainData(txtOperand1, "Operand 1") & DoesTextBoxContainData(txtOperand2, "Operand 2") & DoesTextBoxContainData(txtOperator, "Operator"))
            {
                if ( txtOperator.Text == "/" || txtOperator.Text == "*" || txtOperator.Text == "-" || txtOperator.Text == "+")
                {
                    if (DoesTextBoxContainDecimal(txtOperand1, "Operand 1") & DoesTextBoxContainDecimal(txtOperand2, "Operand 2"))
                    {
                        //MessageBox.Show("data added"); // for testing sake
                        Calculate();
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "You did not enter a proper OPERATOR Ex. /, *, -, +... \n Default to +";
                    txtOperator.Text = "+";
                    if (DoesTextBoxContainDecimal(txtOperand1, "Operand 1") & DoesTextBoxContainDecimal(txtOperand2, "Operand 2"))
                    {
                        //MessageBox.Show("data added"); // for testing sake
                        Calculate();
                    }
                }
            }
        }
        private void Calculate()
        {
            if (txtOperand2.Text == "0" & txtOperator.Text == "/")
            {
                txtResult.Text = "Error";
                lblError.Visible = true;
                lblError.Text = "You cannot devide by Zero  0";
            }
            else
            {
                decimal oper1 = Convert.ToDecimal(txtOperand1.Text);
                decimal oper2 = Convert.ToDecimal(txtOperand2.Text);
                //MessageBox.Show(oper1 + "   xxx   " + oper2); // for testing
                string operatorMath = txtOperator.Text;
                decimal result;
                switch (operatorMath)
                {
                    case "*":
                        result = (oper1 * oper2);
                        break;
                    case "/":
                        result = (oper1 / oper2);
                        break;
                    case "-":
                        result = (oper1 - oper2);
                        break;
                    default:
                        result = (oper1 + oper2);
                        break;
                }

                txtResult.Text = Convert.ToString(Math.Round(result, 4));
            }
        }
        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            clearAllText(txtOperand1);
        }
        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            clearAllText(txtOperand2);
        }
        private void txtOperator_TextChanged(object sender, EventArgs e)
        {
            clearAllText(txtOperator);
        }
        private void clearAllText(TextBox textbox)
        {
            if (textbox.TextLength > 0) { 
                txtResult.Clear();
            }

        }
        private bool DoesTextBoxContainData(TextBox box)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
                return false;
            return true;
        }
        private bool DoesTextBoxContainData(TextBox box, string nameOfTextBox)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                error.SetError(box, $"{nameOfTextBox} does not contain data");
                // MessageBox.Show($"{nameOfTextBox} does not contain data");
                return false;
            }
            return true;
        }
        private bool DoesTextBoxContainDecimal(TextBox box, string name)
        {
            if (DoesTextBoxContainData(box))
            {
                try
                {
                    Convert.ToDecimal(box.Text);
                    return true;
                }
                catch
                {
                    error.SetError(box, $"{name} must be a number!");
                    return false;
                }
            }
            error.SetError(txtOperand1, $"{name} is required");

            return false;

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
                if (c is TextBox)
                {
                    // clear the error on that textbox
                    error.SetError(c, null);
                }
            }
            lblError.Visible = false;
        }
        private void txtOperand2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalculate_Click(this, new EventArgs());
            }
        }
        private void txtOperator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalculate_Click(this, new EventArgs());
            }
        }
        private void txtOperand1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalculate_Click(this, new EventArgs());
            }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtOperator.Text = "/";
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            txtOperator.Text = "*";
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtOperator.Text = "-";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtOperator.Text = "+";
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            btnCalculate.PerformClick();
        }
        private void textBoxFocusLost(object sender, EventArgs e)
        {
            lastFocused = (TextBox)sender;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
                lastFocused.Focus();
                lastFocused.Text = lastFocused.Text + "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            lastFocused.Focus();
            lastFocused.Text = lastFocused.Text + "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            lastFocused.Focus();
            lastFocused.Text = lastFocused.Text + "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            lastFocused.Focus();
            lastFocused.Text = lastFocused.Text + "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            lastFocused.Focus();
            lastFocused.Text = lastFocused.Text + "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            lastFocused.Focus();
            lastFocused.Text = lastFocused.Text + "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            lastFocused.Focus();
            lastFocused.Text = lastFocused.Text + "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            lastFocused.Focus();
            lastFocused.Text = lastFocused.Text + "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            lastFocused.Focus();
            lastFocused.Text = lastFocused.Text + "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            lastFocused.Focus();
            lastFocused.Text = lastFocused.Text + "0";
        }
    }
}
