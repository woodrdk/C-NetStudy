﻿using System;
using System.Windows.Forms;

namespace MethodSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();

        }

        /// <summary>
        /// The following method is used to close the application and checks if the user wants to close, 
        /// if yes then the application closes.
        /// </summary>

        private void ExitApplication()
        {
            DialogResult result = MessageBox.Show("Are you sure? ", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void calcsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }




        
        // delete following
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //********************************************************************
    
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            bool isDataValid = IsDataValid();


            if (IsDataValid())
            {
                double subtotal = Convert.ToDouble(txtSubtotal.Text);
                double taxRate = Convert.ToDouble(txtTaxRate.Text);

                double invoiceTotal = CalculateTotal(subtotal, taxRate);
                DisplayTotal(invoiceTotal);
            }
            
            
        }

        private void DisplayTotal(object invoiceTotal)
        {
            MessageBox.Show($"Your total is {invoiceTotal:c}");
        }

        // calculates the math 
        private double CalculateTotal(double subtotal, double taxRate)
        {
            return subtotal * (1 + taxRate);
        }

        private bool IsDataValid()
        {
            // get user input
            string subtotalInput = txtSubtotal.Text;
            string taxRateInput = txtTaxRate.Text;

            bool isDataValid = false; // flag variable to check if data is true or false
            // check input is valid
            if (IsDouble(subtotalInput) && IsDouble(taxRateInput))
            {
                double subtotal = Convert.ToDouble(subtotalInput);
                double taxRate = Convert.ToDouble(taxRateInput);

                if (IsWithinRange(subtotal, 0.01, 500000) && IsWithinRange(taxRate, 0, 1))
                {
                    isDataValid = true;
                }
            }

            return isDataValid;
        }

        // made this method to validate input is a number
        private bool IsDouble(string input)
        {
            if(double.TryParse(input, out double test))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if a value is within a specific range
        /// </summary>
        /// <param name="testNum">The number to be tested</param>
        /// <param name="minValue">The inclusive minimum value</param>
        /// <param name="maxValue">The inclusive maximum value</param>
        /// <returns></returns>
        private bool IsWithinRange(double testNum, double minValue, double maxValue)
        {
            if(testNum >= minValue && testNum <= maxValue)
            {
                return true;
            }
            return false;
        }
    }
}
