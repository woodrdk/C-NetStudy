using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lunch_Order_Proper
{
    public partial class Form1 : Form
    {
        private List<double> order = new List<double>(); // order list for cost
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); // closes the app from the file menu
        }

        private void rbHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHamburger.Checked)
            {          // if checked it will do the following
                gbAddOns.Visible = true;        // gb is the group box for the addon items for the main course
                gbAddOns.Text = " Add-On Items ($0.75/ each)";
                cbAdd1.Text = "Lettuce, Tomato, and Onions";
                cbAdd2.Text = "Ketchup, Mustard, and Mayo";
                cbAdd3.Text = "French Fries";
            }
            Clear();
        }

        private void rbPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPizza.Checked)
            {   // if checked it will do the following
                gbAddOns.Visible = true;    // gb is the group box for the addon items for the main course
                gbAddOns.Text = " Add-On Items ($0.50/ each)";
                cbAdd1.Text = "Pepperoni";
                cbAdd2.Text = "Sausage";
                cbAdd3.Text = "Olives";
            }
            Clear();
        }

        private void rbSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSalad.Checked)
            {// if checked it will do the following
                gbAddOns.Visible = true;    // gb is the group box for the addon items for the main course
                gbAddOns.Text = " Add-On Items ($0.25/ each)";
                cbAdd1.Text = "Croutons";
                cbAdd2.Text = "Bacon Bits";
                cbAdd3.Text = "Bread Sticks";
            }
            Clear();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (rbPizza.Checked)
            {
                order.Add(5.95);
            }
            if (rbSalad.Checked)
            {
                order.Add(4.95);
            }
            if (rbHamburger.Checked)
            {
                order.Add(6.95);
            }
            if (cbAdd2.Checked == true)
            {
                addCost();
            }
            if (cbAdd1.Checked == true)
            {
                addCost();
            }
            if (cbAdd3.Checked == true)
            {
                addCost();
            }
            // should run a loop instead to go thru all the boxes to find which is checked  to do the adds instead if these ifs  if have time will change
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

           
            order.Clear();
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            order.Clear();
            txtOrderTotal.Text = "";
            txtSubTotal.Text = "";
            txtTax.Text = "";
            ClearAddOns();
        }

        private void ClearAddOns()
        {
            cbAdd1.Checked = false;
            cbAdd2.Checked = false;
            cbAdd3.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addCost()
        {
            if (rbPizza.Checked)
            {
                order.Add(0.50);
            }
            if (rbHamburger.Checked)
            {
                order.Add(0.75);
            }
            if (rbSalad.Checked)
            {
                order.Add(0.25);
            }
        }

        private void cbAdd2_CheckedChanged(object sender, EventArgs e)
        {
            AddOnCostChange();
        }

        private void AddOnCostChange()
        {
            txtOrderTotal.Text = "";
            txtSubTotal.Text = "";
            txtTax.Text = "";
            order.Clear();
        }

        private void cbAdd3_CheckedChanged(object sender, EventArgs e)
        {
            AddOnCostChange();
        }

        private void cbAdd1_CheckedChanged(object sender, EventArgs e)
        {
            AddOnCostChange();
        }
    }
}
