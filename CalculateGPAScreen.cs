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
    public partial class CalculateGPAScreen : Form
    {
        //important variables
        int Semester;   //Semester Number is how many Semester you had
        int SubjectNb;  //Subject Number is how many Subject you had in the i-th Semster
        public static int opencount = 0;    //var to prevent the miscalculation of the accumalative statistics
        public static int Sem = 1;  //Sem is an int that traverse the vector to reach Semster
        List<string> Subjects = new List<string>(); //List to store the subjects grades
        List<double> Hours = new List<double>();    //List to store nb of hours
        List<double> PoS = new List<double>();  //List the store the point of subject for each subject
        List<Tuple<string, double>> Subj = new List<Tuple<string, double>>();   //List Tuple to store the letter grade and the credit hour
        public static List<double> SumPoS = new List<double>(); //List to store the Sum of Pos
        public static List<double> SumHour = new List<double>();    //List to store all credit hour of the subject

        public CalculateGPAScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)  //back button clicked
        {
            Program.Back<CalculateGPAScreen>();
        }

        private void button1_Click(object sender, EventArgs e)  //semester finish button clicked
        {
            //try catch to prevent the semester invalid input
            try
            {
                //taking input from the text box
                Semester = Convert.ToInt32(textBox1.Text);
                if (Semester < 0) throw new Exception("Invalid Semster Number");
                else
                {
                    //get rid of this button, BAMMM, ending it with the dispose-hide axe
                    button1.Dispose();
                    button1.Hide();
                    //reconfirming that the number will be the number that the user entered
                    textBox1.Text = Semester.ToString();
                    //making things appear, WOOOOOSH
                    textBox1.ReadOnly = true;
                    label2.Visible = true;
                    button3.Visible = true;
                    textBox2.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a Valid Semester Number >:( ");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)  //Subject Finish button clicked
        {
            //reminder which semester you are at
            label3.Text = $"Current Semester Number {Sem}";
            label3.Visible = true;
            //try-catch to take the semester number input
            try
            {
                //taking value from text box
                SubjectNb = Convert.ToInt32(textBox2.Text);
                if (SubjectNb < 0) throw new Exception("Invalid Number of Subjects");
                else
                {
                    //make the text box value solid and read-only
                    button3.Visible = false;
                    textBox2.ReadOnly = true;
                    textBox2.Text = SubjectNb.ToString();
                    //clear FLP
                    flowLayoutPanel1.Controls.Clear();
                    //setting the label and adding it to FLP
                    Label label = new Label();
                    label.Text= "Enter your Subject letter grade (A+,A,A-,B+,B,B-,C+,C,C-,D+,D,D-,F) and the subject credit hour\r\n";
                    label.AutoSize = true;
                    flowLayoutPanel1.Controls.Add(label);
                    //as long as there is subject continue adding label, button, combobox
                    for (int i = 1; i <= SubjectNb; i++) {
                        //new label with index and adding it to FLP
                        Label lbl = new Label();
                        lbl.Text = $"Subject Nb {i}:";
                        lbl.AutoSize = true;
                        flowLayoutPanel1.Controls.Add(lbl);
                        //new text box and adding it to FLP
                        TextBox CreditHour = new TextBox();
                        CreditHour.Width = 80;
                        CreditHour.Height = 30;
                        flowLayoutPanel1.Controls.Add(CreditHour);
                        //new combo box and adding list of letter grades and adding it to FLP
                        ComboBox LetterGarde = new ComboBox();
                        LetterGarde.DropDownStyle = ComboBoxStyle.DropDownList;
                        LetterGarde.Width = 80;
                        LetterGarde.Height = 30;
                        LetterGarde.Items.AddRange(new string[] { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
                        flowLayoutPanel1.Controls.Add(LetterGarde);
                        //making an new line
                        flowLayoutPanel1.SetFlowBreak(LetterGarde, true);
                        }
                    //changing visibility to the show statistics and next semester button
                    button4.Visible = true;
                    button5.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a valid Number of Subject Number >:(");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)  //Show statistics button clicked
        {
            if (opencount < Sem)    //if the user was a fool and wanted to open the statistics more than one time
            {
                //Clearing the Lists
                Subjects.Clear();
                Hours.Clear();
                PoS.Clear();
                Subj.Clear();

                // Iterate over the controls in the FlowLayoutPanel
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is ComboBox)    //iterate over combo boxes
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.SelectedItem != null)
                        {
                            Subjects.Add(comboBox.SelectedItem.ToString());
                        }
                    }
                    else if (control is TextBox)    //iterate over text boxes
                    {
                        TextBox textBox = (TextBox)control;
                        if (double.TryParse(textBox.Text, out double creditHour))
                        {
                            Hours.Add(creditHour);
                        }
                    }
                }
                for (int i = 0; i < Subjects.Count; i++)    //add letter grade and credit hours to a list tuple
                {
                    Subj.Add(new Tuple<string, double>(Subjects[i], Hours[i]));
                }

                //Calculating Points of Subjects and credit hours
                for (int k = 0; k < SubjectNb; k++)
                {
                    //calculating the points of subject by multiplying letter grade after turned into number by credit hour
                    PoS.Add(Program.Grade(Subj[k].Item1) * Subj[k].Item2);
                    //Console.WriteLine(PoS[k]+"\n");
                    //Adding the points and hours to the summation of Pos and hours
                    if (k == 0)
                    {
                        SumPoS.Add(PoS[k]);
                        SumHour.Add(Subj[k].Item2);
                    }
                    else
                    {
                        SumPoS[Sem - 1] += PoS[k];
                        SumHour[Sem - 1] += Subj[k].Item2;
                    }
                }

            }
            //open count +1
            opencount++;
            //open the statistics form
            Program.OpenForm<Statistics>();
            
        }

        private void button5_Click(object sender, EventArgs e)  //Next semester button clicked
        {
            if (Sem == Semester)    //if finished all semester
            {
                MessageBox.Show("You Finished All Your Semesters");
                this.Close();
            }
            else   // go do this function
            {
                Reset();
            }
        }

        private void Reset()    //function to make lot of changes
        {
            //semester +1
            Sem++;
            //subjects text box clear and make it accessible again
            textBox2.Clear();
            textBox2.ReadOnly = false;
            //show subjects finish button again and hide the next term and statistics buttons to not have to face stupid actions from the user
            button3.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
            //clear the FLP
            flowLayoutPanel1.Controls.Clear();
            //open count reset to number that is no opens yet
            opencount = Sem - 1;
        }

        private void CalculateGPAScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CalculateGPAScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
