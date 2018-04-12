using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            /*
            if (length == "" || width == "")
            {
                throw new System.InvalidProgramException("Numbers are missing for the calculation.");
            }
            */
            
        }

        private void lblPerimeter_Click(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
