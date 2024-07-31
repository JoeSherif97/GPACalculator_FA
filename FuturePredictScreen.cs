using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GPA_Calculator_FA_CSharpy
{
    public partial class FuturePredictScreen : Form
    {
        //Some important variables
        public static double CurrentGPA;    // var to store current gpa
        public static double FutureGPA; // var to store future gpa
        public static double EstimatedGPA;  // var to store estimated gpa
        public static double MaximumGPA;    // var to store maximum gpa

        public FuturePredictScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)  //back to main screen button
        {
            Program.Back<FuturePredictScreen>();
        }

        private void button1_Click(object sender, EventArgs e)  //finish button clicked
        {
            richTextBox1.Text = null;
            //taking inputs from text boxes
            CurrentGPA = double.Parse(textBox1.Text);
            FutureGPA = double.Parse(textBox2.Text);
            //calculating estimated and future gpas
            EstimatedGPA = (2 * FutureGPA) - CurrentGPA;
            MaximumGPA = (4 + CurrentGPA) / 2;

            if (EstimatedGPA > 4.0) //if unachiveable
            {
                richTextBox1.Text = "You Cannot Reach this GPA by Next Semester, But If you Get GPA of 4, You will reach GPA of " + Math.Round(MaximumGPA, 3).ToString();
            }
            else   //if achiveable
            {
                richTextBox1.Text = "You will need An Estimated GPA of " + Math.Round(EstimatedGPA, 3).ToString() + " to reach this GPA of " + FutureGPA.ToString();
            }
            richTextBox1.Visible = true;
        }

        private void FuturePredictScreen_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
