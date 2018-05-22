using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listFormAssignment
{
    public partial class frmListForm : Form
    {
        string[] user = new string[10];
        public frmListForm()
        {
            InitializeComponent();
        }

        private void frmListForm_Load(object sender, EventArgs e)
        {
            // Create a Windows forms application that allows the user to type a name in a textbox and add them to a user list.
            // The names should be stored in an array. 
            // When the array gets to 10 elements, pop up a messagebox telling the user that no more names may be entered.
            // Finally the user can click a display button that will show the SORTED list of names in REVERSE alphabetical order.
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name!");

            }
            else
            {
                user.Add(txtName.Text.Trim());
                MessageBox.Show("Name added");
            }
            txtName.Clear();
            txtName.Focus();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            user.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lstNames.Items.Clear();
            string searchTerm = txtSearch.Text.Trim().ToLower();
            searchTerm = searchTerm.Trim();

            if (searchTerm == string.Empty)
            {
                return;
            }

            foreach (string stu in user)
            {
                if (stu.ToLower().Contains(searchTerm))
                {
                    lstNames.Items.Add(stu);
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (user.Count == 0)
            {
                MessageBox.Show("No Names");
                return;
            }

            if (user.Count == 10)
            {
                MessageBox.Show("You are at limit of 10 names");
            }

            string display = string.Join("\n", user);
            MessageBox.Show(display);

        }
    }
}
