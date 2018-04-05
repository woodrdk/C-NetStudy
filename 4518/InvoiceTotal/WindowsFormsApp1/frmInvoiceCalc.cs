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
    public partial class frmInvoiceCalc : Form
    {
        public frmInvoiceCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcTotal_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("You Clicked!");
            // get subtotal
            string subtotal = txtSubtotal.Text;
            double subTNum = Convert.ToDouble(subtotal);

            // get tax rate (assume between 0 & 1)
            double taxrate = Convert.ToDouble(txtTaxRate.Text);

            // calculation
            double total = subTNum * (1 + taxrate);
            //MessageBox.Show(total.ToString());

            // sends the results to the text box for total
            txtTotal.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // do notes and  c # code here for objects sometimes 
            // example making read only txtTotal.ReadOnly = true;
        }
    }
}
