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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) //if clicked on close button
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)  //if clicked on exit button
        {
            Program.OpenForm<ExitScreen>();
        }

        private void button2_Click(object sender, EventArgs e)  //if clicked on letter grader button
        {
            Program.OpenForm<LetterGraderScreen>();
        }

        private void button4_Click(object sender, EventArgs e)  //if clicked on average grade planner button
        {
            Program.OpenForm<AvgGradePlanScreen>();
        }

        private void button3_Click(object sender, EventArgs e)  //if clicked on future predictor button
        {
            Program.OpenForm<FuturePredictScreen>();
        }

        private void button1_Click(object sender, EventArgs e)  //if clicked on calculate gpa button
        {
            Program.OpenForm<CalculateGPAScreen>();
        }

        private void button6_Click_1(object sender, EventArgs e)    //if clicked on about button
        {
            Program.OpenForm<AboutForm>();

        }
        private void button5_Click(object sender, EventArgs e)  //if clicked on max grade planner button
        {
            Program.OpenForm<MaxGradePlanScreen>();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        //if hovered over buttons
        private void button2_MouseHover(object sender, EventArgs e) 
        {
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(button2, "This feature allows users to input their Grade Point Average (GPA)\r\nand receive the corresponding letter grade based on a predefined grading scale.");
            
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(button3, "This feature allows users to input their current GPA and the target GPA they aim to achieve.\r\nThe program then calculates the GPA needed in the next semester to reach the target GPA.");

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(button4, "This feature allows users to input their current GPA and the GPA they aim to achieve.\r\nThe program calculates the average letter grade the user needs\r\nto obtain in their subjects next semester to reach the target GPA.");

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(button5, "This feature enables users to input the number of subjects they will take in the next semester,\r\nalong with their current GPA and desired GPA.\r\nThe program calculates the specific grades needed in each subject to achieve the target GPA,\r\nassuming all subjects have the same credit hours.");

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(button6, "This feature is About, meaning it shows what is About the Program.");

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(button7, "this feature let you exit our app");

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(button1, "This feature allows users to input their Grade Point Average (GPA)\r\nand receive the corresponding letter grade based on a predefined grading scale.");

        }
    }
}
