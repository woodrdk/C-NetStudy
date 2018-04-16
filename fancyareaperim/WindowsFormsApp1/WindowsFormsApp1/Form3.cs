using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExitFancy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackfancy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double test = 0.0;
            if (double.TryParse(txtSide1.Text, out test) && double.TryParse(txtSide2.Text, out test)
                && double.TryParse(txtSide3.Text, out test) && double.TryParse(txtSide4.Text, out test))
            {
                string side1 = txtSide1.Text;
                double dblSide1 = Convert.ToDouble(side1);

                string side2 = txtSide2.Text;
                double dblSide2 = Convert.ToDouble(side2);

                string side3 = txtSide3.Text;
                double dblSide3 = Convert.ToDouble(side3);

                string side4 = txtSide4.Text;
                double dblSide4 = Convert.ToDouble(side4);


                double area = 0.0;
                double perimeter = dblSide1 + dblSide2 + dblSide3 + dblSide4;
                string measurementMethod = "";
//double inchesLeft = 0;

                if (cbStandard.Checked == true)
                {
                    if (cbFeet.Checked == true)
                    {
                        measurementMethod = " Feet";
                        
  //                      inchesLeft = (perimeter - Math.Truncate(perimeter))/12;
  //                      perimeter = Math.Truncate(perimeter);
                    }
                    else{
                        measurementMethod = " Inches";
                    }
                }
                if(cbMetric.Checked == true)
                {
                    if (cbMeters.Checked == true)
                    {
                        measurementMethod = " Meters";
                    }
                    else
                    {
                        measurementMethod = " Centimeters";
                    }
                }



                txtPerimeter.Text = perimeter.ToString() + measurementMethod;// + inchesLeft;

                if ((dblSide1 == dblSide3) && (dblSide2 == dblSide4 ))
                {
                    area = dblSide1 * dblSide2;              
                }
                else if((dblSide1 == dblSide3))
                {
                    area = (((dblSide2 + dblSide4)*dblSide1)/2);
                }
                else if ((dblSide2 == dblSide4))
                {
                    area = (((dblSide1 + dblSide3) * dblSide2) / 2);
                }

               
                
                txtArea.Text = area.ToString() + measurementMethod + "\xB2";


                if (dblSide1== 0 || dblSide2 == 0 || dblSide3 == 0 || dblSide4 == 0)
                {
                    txtArea.Text = "Error";
                    //for(int i = 1; i < 5; i++) {}
                    String Value = "Enter A Value";
                    if (dblSide1 == 0)
                    {
                        txtSide1.Text = Value;
                    }
                    if (dblSide2 == 0)
                    {
                        txtSide2.Text = Value;
                    }
                    if (dblSide3 == 0)
                    {
                        txtSide3.Text = Value;
                    }
                    if( dblSide4 ==0)
                    {
                        txtSide4.Text = Value;
                    }
                }
                
               

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInches.Checked == true)
            {
                cbFeet.Checked = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cbMetric_CheckedChanged(object sender, EventArgs e)
        {
            
            
            if (cbMetric.Checked == true)
            {
                cbStandard.Checked = false;
                cbMeters.Show();
                cbCentimeters.Show();
            }
            else
            {
                cbMeters.Hide();
                cbCentimeters.Hide();
                cbMeters.Checked = false;
                cbCentimeters.Checked = false;

            }
        }

        private void cbStandard_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbStandard.Checked == true)
            {
                cbMetric.Checked = false;
                cbFeet.Show();
                cbInches.Show();
            }
            else
            {
                cbFeet.Hide();
                cbInches.Hide();
                cbFeet.Checked = false;
                cbInches.Checked = false;
            }

        }

        private void cbMeters_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMeters.Checked == true)
            {
                cbCentimeters.Checked = false;
            }

        }

        private void cbCentimeters_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCentimeters.Checked == true)
            {
                cbMeters.Checked = false;
            }
        }

        private void cbFeet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFeet.Checked == true)
            {
                cbInches.Checked = false;
            }
        }
    }
}
