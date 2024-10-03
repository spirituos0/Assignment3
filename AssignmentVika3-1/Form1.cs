using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentVika3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            float weight, height, bmi;
            string status = "";
            if (float.TryParse(weightText.Text, out weight) &&
                float.TryParse(heightText.Text, out height))
            {
                bmi = weight / (height * height) * 703;
                if (bmi < 18.5f)
                {
                    status = "underweight";
                }
                else if (bmi >= 18.5f && bmi <= 25)
                {
                    status = "optimal";
                }
                else
                {
                    status = "overweight";
                }
                bmiText.Text = $"BMI: {bmi:F2}";
                statusText.Text = $"Status: {status}";
            }
            else
            {
                MessageBox.Show("Please enter valid input.");
            }
        }
    }
}
