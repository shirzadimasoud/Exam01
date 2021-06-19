using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exam01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {  
            try
            {
                double A = Convert.ToDouble(z1TextBox.Text);
                double B = Convert.ToDouble(z2TextBox.Text);
                double C = Convert.ToDouble(z3TextBox.Text);
                double P;

                if ((A < (B + C)) && (B < (A + C)) && (C < (A + B)))
                {
                    P = (A + B + C) / 2;
                    resultTextBox.Text = Math.Sqrt(P * (P - A) * (P - B) * (P - C)).ToString();
                }
                else
                {

                }
            }
            catch (Exception) { MessageBox.Show("لطفاً ورودی های خود را بررسی نمایید"); }
        }
    }
}
