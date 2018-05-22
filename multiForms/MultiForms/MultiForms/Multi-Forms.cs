using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForms
{
    public partial class frmMultiForms : Form
    {
        public frmMultiForms()
        {
            InitializeComponent();
        }

        private void radStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (radStudent.Checked)
            {
                lblOutput.Text = "Great! You get student discount!";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radFaculty_CheckedChanged(object sender, EventArgs e)
        {
            if (radFaculty.Checked)
            {
                lblOutput.Text = "You are faculty, good job!";
            }
        }

        private void radGender_CheckChanged(object sender, EventArgs e)
        {
            string gender = string.Empty;

            //RadioButton currRadButton = (RadioButton)sender;
            // or  folllowing line
            RadioButton currRadButton = sender as RadioButton;
            if (currRadButton.Checked)
            {
                gender = currRadButton.Text;
                // MessageBox.Show(currRadButton.Text); or
               // MessageBox.Show($"You chose {gender}");
            }
        }

        private void frmMultiForms_Load(object sender, EventArgs e)
        {
            radStudent.Checked = true;
            radMale.Checked = true;
        }

        private void chkCourses_CheckChanged(object sender, EventArgs e)
        {
            int numOptionsChecked = 0;
            // loop thru every control on the form
            foreach (Control c in this.Controls)
            {
                // check if current control is a CheckBox
                if (c is CheckBox)
                {
                    // casting control as CheckBox
                    CheckBox box = c as CheckBox;
                    if (box.Checked)
                    {
                        numOptionsChecked++;
                    }
                }
            }
            MessageBox.Show(numOptionsChecked.ToString());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSecondForm_Click(object sender, EventArgs e)
        {
            frmSecondary otherForm = new frmSecondary();
            // or var otherForm = new frmSecondary();
            DialogResult res = otherForm.ShowDialog();

            if (res == DialogResult.OK)
            {
                MessageBox.Show("thanks!");

            }
            else
            {
                MessageBox.Show("Come back soon");
            }
        }
    }
}
