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
    public partial class frmSortedScores : Form
    {
       
        public frmSortedScores()
        {
            InitializeComponent();
        }

        private void frmSortedScores_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
