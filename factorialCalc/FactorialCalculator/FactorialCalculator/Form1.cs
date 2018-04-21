using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumber.Text);
            if (num > 0 && num < 21)
            {
                long factorial = 1;
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                
                txtFactorial.Text = Convert.ToString(String.Format("{0:#,##0}", factorial));

            }
            else
            {
                lblError.Visible = true;
                lblError2.Visible = true;
            }

            
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            txtFactorial.Text = "";
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalc_Click(this, new EventArgs());
            }
        }

        private void txtNumber_DoubleClick(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtFactorial.Text = "";
            lblError.Visible = false;
            lblError2.Visible = false;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
