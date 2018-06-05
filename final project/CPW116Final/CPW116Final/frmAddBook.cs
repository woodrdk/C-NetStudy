using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPW116Final
{
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookTitle.Clear();
            txtISBN.Clear();
            txtPrice.Clear();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(txtISBN.Text == "")
            {
                txtISBN.Text = "Enter an ISBN";
            }
            if (txtBookTitle.Text == "") {
                txtBookTitle.Text = "Enter a book Title";
            }
            if (txtPrice.Text == "")
            {
                txtPrice.Text = "Enter a Price";
            }

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
