using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPassingByReference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearTextbox(textBox1);
            ClearTextbox(textBox2);
            ClearTextbox(textBox3);
        }

        private void ClearTextbox(TextBox box)
        {
            box.Clear();
            box.BorderStyle = BorderStyle.Fixed3D;
            box.Font = new Font("Areial",24, FontStyle.Italic);
            // box.Text = string.Empty;
        }
    }
}
