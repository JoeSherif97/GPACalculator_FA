using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator_FA_CSharpy
{
    public partial class AvgGradePlanScreen : Form
    {
        //Some important variables
        public static double CurrentGPA;    // var to store current gpa
        public static double FutureGPA; // var to store future gpa
        public static double EstimatedGPA;  // var to store estimated gpa
        public static double MaximumGPA;    // var to store maximum gpa

        public AvgGradePlanScreen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  //back button click
        {
            Program.Back<AvgGradePlanScreen>();
        }

        private void button1_Click(object sender, EventArgs e)  //finish button click
        {
            richTextBox1.Text = null;
            //taking values from the two text boxes
            CurrentGPA = double.Parse(textBox1.Text);
            FutureGPA = double.Parse(textBox2.Text);
            //calculating estimated and maximum gpa 
            EstimatedGPA = (2 * FutureGPA) - CurrentGPA;
            MaximumGPA = (4 + CurrentGPA) / 2;

            if (EstimatedGPA > 4.0) //if gpa unreachable
            {
                richTextBox1.Text = "You Cannot Reach this GPA by Next Semester, But If you get " + Program.GGPA(4.00) + " in all of your Subjects, You will reach GPA of " + Math.Round(MaximumGPA, 3).ToString();
            }
            else   //if reachable
            {
                richTextBox1.Text= "You will need to get Average of " + Program.GGPA(EstimatedGPA) + " in your Subjects Next Semester to reach this GPA of " + FutureGPA.ToString();
            }
            richTextBox1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AvgGradePlanScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
