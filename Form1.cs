using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatPercentageCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Double dblCal, dblGram, dblTotal, dblPercentage;
            dblCal = Convert.ToDouble(txtCal.Text);
            dblGram = Convert.ToDouble(txtGrams.Text);
            if(dblCal < 0 || dblGram < 0 || dblGram > dblCal)
            { MessageBox.Show("Incorrect input of data"); }
            else { 
            dblTotal = dblGram * 9;
            dblPercentage = dblTotal / dblCal;
            if (chkWantToKnow.Checked == true && dblPercentage < 0.3)
            {
                
                lblOut.Text = "Total Number of Calories From fat: "+ dblTotal.ToString("n2") + Environment.NewLine + 
                    "Percentage of Calories that come from fat: " + dblPercentage.ToString("P") + Environment.NewLine + 
                    "Low Fat food";

            }
            else
            {
               
                lblOut.Text = "Total Number of Calories From fat: " + dblTotal.ToString("n2") + Environment.NewLine +
                    "Percentage of Calories that come from fat: " + dblPercentage.ToString("P");
            }
            }
        }
    }
}
