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
    public partial class MaxGradePlanScreen : Form
    {
        //Some important variables
        public static double CurrentGPA;    // var to store current gpa
        public static double FutureGPA; // var to store future gpa
        public static double EstimatedGPA;  // var to store estimated gpa
        public static double MaximumGPA;    // var to store maximum gpa

        public MaxGradePlanScreen()
        {
            InitializeComponent();
        }

        private void MaxGradePlanScreen_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  //back button clicked
        {
            Program.Back<MaxGradePlanScreen>();
        }

        private void button1_Click(object sender, EventArgs e)  //finish button clicked
        {
            //clearing the RTB
            richTextBox1.Text = null;
            //taking the inputs from the text boxes
            int SubjectsNumber = Convert.ToInt32(textBox1.Text);
            CurrentGPA = double.Parse(textBox2.Text);
            FutureGPA = double.Parse(textBox3.Text);
            //calculating the estimated and future gpas
            EstimatedGPA = (2 * FutureGPA) - CurrentGPA;
            MaximumGPA = (4 + CurrentGPA) / 2;
            //creating a list to contain the grades planned that the user must get
            List<string> Subjects = new List<string>(SubjectsNumber);
            //two counter the prior is an indexer to the subjects, and the latter is an checker to tell the user if he has any subjects to get as he wish in them
            int counter = 1;
            int SubjectChecker = SubjectsNumber;
            if (EstimatedGPA > 4.0) //if unreachable
            {
                double Weight = MaximumGPA * SubjectsNumber;    //make the weight which will be subtracted from
                while (Weight > 0)  //as long as weight isn't zero, continue torning it up
                {
                    //placeholder to store the weight which got transformed into letter grade then got transformed into number
                    double PlaceHolder = Program.Grade(Program.GGPA(Weight));
                    //adding the letter grade to our list
                    Subjects.Add(Program.GGPA(Weight));
                    //subtracting the added grade from the weight
                    Weight -= PlaceHolder;
                }
                richTextBox1.Text = "you must get at least ";
                while (Subjects.Any())  //as long as there is letter grades left, CONTINUE
                {
                    //adding the subject with index and the letter grade that the user must get in this subject
                    richTextBox1.Text += "\r\nSubject Number " + counter.ToString() + " : " + Subjects.First();
                    //we don't need the subject anymore, getting rid of it, BOOM, gunshot sound...
                    Subjects.RemoveAt(0);
                    //indexer +1
                    counter++;
                }
                //to make the user remember what gpa he wanted to reach or can reach
                Console.WriteLine("\r\nto reach this GPA of " + Math.Round(MaximumGPA, 3));
            }
            else   //if reachable
            {
                double Weight = EstimatedGPA * SubjectsNumber;  //make the weight which will be subtracted from
                while (Weight > 0)  //as long as weight isn't zero, continue torning it up
                {
                    //placeholder to store the weight which got transformed into letter grade then got transformed into number
                    double PlaceHolder = Program.Grade(Program.GGPA(Weight));
                    //adding the letter grade to our list
                    Subjects.Add(Program.GGPA(Weight));
                    //subtracting the added grade from the weight
                    Weight -= PlaceHolder;
                    //Free Subject -1
                    SubjectChecker--;
                }
                richTextBox1.Text = "you must get at least ";
                while (Subjects.Any())  //as long as there is letter grades left, CONTINUE
                {
                    //adding the subject with index and the letter grade that the user must get in this subject
                    richTextBox1.Text += "\r\nSubject Number " + counter.ToString() + " : " + Subjects.First();
                    //we don't need the subject anymore, getting rid of it, BOOM, gunshot sound...
                    Subjects.RemoveAt(0);
                    //indexer +1
                    counter++;
                }
                if (SubjectChecker > 0) //if the user has any free subject, go tell him
                    richTextBox1.Text += "\r\nOh you are Lucky, You Have " + SubjectChecker.ToString() + " Subjects you can do in them as you want";

                //to make the user remember what gpa he wanted to reach or can reach
                Console.WriteLine("\r\nto reach this GPA of " + Math.Round(EstimatedGPA, 3));
            };
            //showing all what we were writing in the RTB
            richTextBox1.Visible = true;
        }
    }
}
