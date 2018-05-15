using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrderForm
{
    public partial class frmLunchOrder : Form
    {

        private List<double> order = new List<double>();
        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void rbHamburger_CheckedChanged(object sender, EventArgs e)
        {
            AddOnItemVisible(gbAddOnHamburger);
            order.Add(6.95);
        }      
        private void AddOnItemVisible(GroupBox food)
        {
            
            if (food.Visible == true)
            {
                food.Visible = false;
            }
            else
            {
                food.Visible = true;
            }
        }
        private void rbPizza_CheckedChanged(object sender, EventArgs e)
        {
            AddOnItemVisible(gbAddOnPizza);
            order.Add(5.95);
        }
        private void gbMainCourse_Enter(object sender, EventArgs e)
        {

        }
        private void rbSalad_CheckedChanged(object sender, EventArgs e)
        {
            AddOnItemVisible(gbAddOnSalad);
            order.Add(4.95);
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double subtotal = 0;
            for (int i = 0; i < order.Count; i++)
            {
                subtotal += order[i];
            }

            
            txtSubTotal.Text = subtotal.ToString("C");

            double tax = 0.075;
            double totalTax = subtotal * tax;
            txtTax.Text = totalTax.ToString("C");

            txtOrderTotal.Text = (subtotal + totalTax).ToString("C");
            
            

            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cbLettuce_CheckedChanged(object sender, EventArgs e)
        {
            order.Add(0.75);
        }
        private void cbTomato_CheckedChanged(object sender, EventArgs e)
        {
            order.Add(0.75);
        }
        private void cbOnion_CheckedChanged(object sender, EventArgs e)
        {
            order.Add(0.75);
        }
        private void cbKetrchup_CheckedChanged(object sender, EventArgs e)
        {
            order.Add(0.75);
        }
        private void cbMustard_CheckedChanged(object sender, EventArgs e)
        {
            order.Add(0.75);
        }
        private void cbMayo_CheckedChanged(object sender, EventArgs e)
        {
            order.Add(0.75);
        }
        private void cbFrenchFries_CheckedChanged(object sender, EventArgs e)
        {
            order.Add(0.75);
        }
        private void cbCroutons_CheckedChanged(object sender, EventArgs e)
        {
            order.Add(0.25);
        }
        private void cbBaconbits_CheckedChanged(object sender, EventArgs e)
        {
            order.Add(0.25);
        }
        private void cbBreadsticls_CheckedChanged(object sender, EventArgs e)
        {
            order.Add(0.25);
        }
        private void cbPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            order.Add(0.50);
        }
        private void cbSausage_CheckedChanged(object sender, EventArgs e)
        {
            order.Add(0.50);
        }
        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            order.Add(0.50);
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            order.Clear();
            txtOrderTotal.Text = "";
            txtSubTotal.Text = "";
            txtTax.Text = "";
            gbAddOnHamburger.Visible = false;
            gbAddOnPizza.Visible = false;
            gbAddOnSalad.Visible = false;
        }
    }
}
