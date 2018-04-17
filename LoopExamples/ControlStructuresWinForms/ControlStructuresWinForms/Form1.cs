using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlStructuresWinForms
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }
        int sum;
        private void btnCalc_Click(object sender, EventArgs e)
        {
           
            string input = txtUserNum.Text;
            int num = Convert.ToInt32(input);
            sum += num;
            MessageBox.Show(sum.ToString());
        }

        private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to quit? ", "Do you want to quit? ", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(choice == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("You should purchase this software");
            }
        }
    }
}
