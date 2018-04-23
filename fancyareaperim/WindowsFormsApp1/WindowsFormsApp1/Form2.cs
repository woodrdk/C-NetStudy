using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExitBasic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackBasic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double test = 0.0;

            
            if (double.TryParse(txtWidth.Text, out test) && double.TryParse(txtLength.Text, out test))
            {
                string length = txtLength.Text;
                double dblLength = Convert.ToDouble(length);

                string width = txtWidth.Text;
                double dblWidth = Convert.ToDouble(width);

                double area = dblLength * dblWidth;
                double perimeter = (2 * dblLength) + (2 * dblWidth);

                txtArea.Text = area.ToString();
                txtPerimeter.Text = perimeter.ToString();

            }
        }

        private void lblWidth_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to quit? ", "Do you want to quit? ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void txtLength_DoubleClick(object sender, EventArgs e)
        {
            bool where = false;
            clearAllText(where);
        }

        private void txtWidth_DoubleClick(object sender, EventArgs e)
        {
            bool where = true;
            clearAllText(where);
        }

        private void clearAllText(bool where)
        {           
            if (where == true)
            {
                txtWidth.Text = "";
            }
            if (where == false)
            {
                txtLength.Text = "";
            }
            txtArea.Text = "";
            txtPerimeter.Text = "";
        }

        private void txtLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalc_Click(this, new EventArgs());
            }
        }



        private void txtWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalc_Click(this, new EventArgs());
            }
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            txtArea.Text = "";
            txtPerimeter.Text = "";
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            txtArea.Text = "";
            txtPerimeter.Text = "";
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            // was going to use but wont allow decimals ... 
            // will need to research how to do both this way
            // if possible   e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // was going to use but wont allow decimals ... 
            // will need to research how to do both this way
            // if possible  e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
