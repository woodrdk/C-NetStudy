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


            double price = Convert.ToDouble(txtPrice.Text);
            string Title = txtBookTitle.Text;
            string ISBN = (txtISBN.Text);

            //add all data to book object
            //METHOD 1: POPULATE OBJECT PROPERTY BY PROPERTY
            var addBook = new Book();
            addBook.Price = price;
            addBook.Title = Title;
            addBook.ISBN = ISBN;

            txtBookTitle.Clear();
            txtISBN.Clear();
            txtPrice.Clear();
            

            if (BookDB.AddBookNow(addBook))
            {
                MessageBox.Show("Book Added!");

                this.Tag = ISBN;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Book cannot be added at this time!");
            }
        }
    

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmAddBook_Load(object sender, EventArgs e)
        {

        }
        private void frmAddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
