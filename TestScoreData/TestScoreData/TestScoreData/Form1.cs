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

        List<double> Scores = new List<double>();
        List<double> ScoresSorted = new List<double>();

        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        private void FrmScoreCalculator_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDisplayUnsortedScores_Click(object sender, EventArgs e)
        {
            var message = string.Join(Environment.NewLine, Scores);
            MessageBox.Show(message);

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtScore.Text == "")
            {
                MessageBox.Show("Please enter a Score!");
            }
            
            else
            {

                try
                {
                    var num = Convert.ToDouble(txtScore.Text.Trim());

                    if (num > 0 && num < 100)
                    {
                        Scores.Add(num);
                        txtScore.Clear();
                        txtScore.Focus();

                        txtScoreCount.Text = Scores.Count.ToString();

                        double total = 0;
                        for (var i = 0; i < Scores.Count; i++)
                        {
                            total += (Scores[i]);
                        }
                        txtScoreTotal.Text = total.ToString();
                        txtAverage.Text = (total / Scores.Count).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Enter a number between 0 and 100");
                        txtScore.Text = "";
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show("You Did Not Enter A Number");
                }
            }
        }

        private void BtnClearScores_Click(object sender, EventArgs e)
        {
            Scores.Clear();
            txtAverage.Text = "";
            txtScore.Text = "";
            txtScoreCount.Text = "";
            txtScoreTotal.Text = "";

        }

        private void BtnDisplayScores_Click(object sender, EventArgs e)
        {
            ScoresSorted = new List<double>(Scores);
            ScoresSorted.Sort();
            var messageSort = string.Join(Environment.NewLine, ScoresSorted);
            MessageBox.Show(messageSort);
        }

        private void TxtScore_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtScore.Text, "  ^ [0-9]"))
            {
                txtScore.Text = "";
            }
        }

        private void TxtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
