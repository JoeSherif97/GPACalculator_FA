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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "GPA Calculator Application Documentation\r\nOverview\r\n\r\nThe GPA Calculator application is a Graphical-Based program designed to calculate various GPA metrics based on the GPA system of Future Academy. It includes functionalities to calculate current and cumulative GPA, convert GPA to letter grades, and determine the required GPA for future goals. The application is written in C# and provides a user-friendly interface to manage GPA calculations effectively.\r\nFeatures\r\n\r\n1.GPA Calculation\r\n~Calculates current semester GPA.\r\n~Calculates cumulative GPA over multiple semesters.\r\n~Converts GPA to corresponding letter grades.\r\n\r\n2.Future GPA Calculator\r\n~Determines the GPA required in the next semester to achieve a target GPA.\r\n\r\n3.Grade Requirements Calculator\r\n~Calculates the average letter grade required in all subjects to reach a specific GPA.\r\n~Provides guidance on the highest letter grades needed in specific subjects to achieve a desired GPA.\r\n\r\n4.Permitted Hours Calculation\r\n~Determines the number of credit hours a student is allowed to take based on their GPA.\r\n\r\n5.Menu and Navigation\r\n~Main menu with options for different functionalities.\r\n~About section with information about the application and its developers.\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Back<AboutForm>();
        }
    }
}
