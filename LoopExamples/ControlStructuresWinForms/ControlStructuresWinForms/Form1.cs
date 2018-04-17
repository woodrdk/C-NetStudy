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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
