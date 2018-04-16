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
    }
}
