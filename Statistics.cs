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
    public partial class Statistics : Form
    {
        //two var thr prior is for total points and the latter for the total hours
        static double TP = 0;
        static double TH = 0;

        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)    //when the form is loading
        {
            //setting  the labels' text
            label1.Text = $"Semester {CalculateGPAScreen.Sem} Statistics";
            label2.Text = $"Semester Credit Hours are {CalculateGPAScreen.SumHour[CalculateGPAScreen.Sem - 1]}";
            label3.Text = $"Semester GPA is {CGPA(CalculateGPAScreen.SumPoS,CalculateGPAScreen.SumHour,CalculateGPAScreen.Sem)}";
            label4.Text = $"Semester Letter Grade is {Program.GGPA(CGPA(CalculateGPAScreen.SumPoS, CalculateGPAScreen.SumHour, CalculateGPAScreen.Sem))}";
            //if condition to prevent the incrementing of accumulative gpa if the user opened the statistics window multiple times
            if (CalculateGPAScreen.Sem == CalculateGPAScreen.opencount)
            {
                //when clicked once, adding the semester statistics to the accumalative statistics
                TH += CalculateGPAScreen.SumHour[CalculateGPAScreen.Sem - 1];
                TP += CalculateGPAScreen.SumPoS[CalculateGPAScreen.Sem - 1];
            }
            label5.Text = $"Accumalative Statistics";
            label6.Text = $"Total Credit Hours are {TH}";
            label7.Text = $"Accumalative GPA is {AGPA(TP,TH)}";
            label8.Text = $"The Letter Grade of Your Accumalative GPA is {Program.GGPA(AGPA(TP,TH))}";
            label10.Text = $"Permitted Hours for your next semester are {Permitted(AGPA(TP, TH))}";
            //setting the labels' location
            label1.Location = new System.Drawing.Point(392 - label1.Width / 2,13);
            label5.Location = new System.Drawing.Point(392 - label1.Width / 2, 222);
            if (AGPA(TP, TH) < 2.0) //Alert for the less than 2 gpa users
            {
                //setting the label text and visibility
                label9.Text = $"Take Care, If Your Accumalative GPA Stayed Equal to 2.0\r\nor Less For More Than 4 Semesters, You will be Terminated";
                label9.Visible = true;
            }
        }

        private void BreakLine_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  //back button clicked
        {
            this.Close();
        }
        static double CGPA(List<double> P, List<double> H, int s) //Function to return the current semester GPA
        {
            double cgpa = (P[s - 1] / H[s - 1]);
            return Math.Round(Math.Round(cgpa,3),2);
        }

        static double AGPA(double tP, double tH) //Function to return the Accumalative GPA
        {
            double agpa = (tP / tH);
            return Math.Round(Math.Round(agpa,3),2);
        }
        static double Permitted(double gpa) //Function to return the permitted number of hour that the student can take depends on the gpa
        {
            if (gpa >= 3.0) return 21;
            else if (gpa < 3.0 && gpa >= 2.0) return 18;
            else if (gpa < 2.0 && gpa >= 1.0) return 15;
            else if (gpa < 1.0 && gpa >= 0) return 12;
            else return 0;
        }
    }
}
