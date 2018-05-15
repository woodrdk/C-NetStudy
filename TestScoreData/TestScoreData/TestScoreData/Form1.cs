using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScoreData
{
    public partial class frmScoreCalculator : Form
    {

        List<string> Scores = new List<string>();


        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        private void frmScoreCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to quit? ", "Do you want to quit? ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("Thank you for using this score calculator");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDisplayUnsortedScores_Click(object sender, EventArgs e)
        {
            frmSortedScores secondForm = new frmSortedScores();
            secondForm.TakeThis(Scores); // passing the list
            secondForm.Show();
            
            
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("Please enter a Score!");
            }
            else
            {
                Scores.Add(txtScore.Text.Trim());
            }
            txtScore.Clear();
            txtScore.Focus();
         
            txtScoreCount.Text = Scores.Count.ToString();

            double total = 0;
            for (var i = 0; i < Scores.Count; i++)
            {
                total += Int32.Parse(Scores[i]);
            }
            txtScoreTotal.Text = total.ToString();
            txtAverage.Text = (total / Scores.Count).ToString();
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            Scores.Clear();
        }
    }
}
