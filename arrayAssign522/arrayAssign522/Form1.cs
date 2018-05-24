using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrayAssign522
{
    public partial class frmArrayAssign : Form
    {
        public frmArrayAssign()
        {
            InitializeComponent();
        }
        string[] myNames = new string[10];
        int count = 0;

        private void btnAddName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name!");
            }
            else
            {
                if (count < 10)
                {
                    myNames[count] = (txtName.Text.Trim());
                    //MessageBox.Show("Name added");
                    count++;
                }
                else {
                    MessageBox.Show("No more names may be entered.");
                }
            }
            txtName.Clear();
            txtName.Focus();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            myNames = myNames.OrderByDescending(d => d).ToArray();
            textBoxNames.Text = string.Join("\n", myNames);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(myNames, 0, myNames.Length);
            textBoxNames.Text = string.Empty;
        }
    }
}
