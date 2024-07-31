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
    public partial class LetterGraderScreen : Form
    {
        public LetterGraderScreen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  //finish button clicked
        {
            //clearing the labels' text
            label3.Text = null;
            label5.Text = null;
            //filling the labels' text
            label3.Text = Program.GGPA(Convert.ToDouble(textBox1.Text)).ToString().ToUpper();
            label5.Text = ((Convert.ToDouble(textBox1.Text) / 4.00)*100).ToString()+"%";
            //putting the value into the progress bar 
            progressBar1.Value= Convert.ToInt32(Math.Round(((Double.Parse(textBox1.Text)/4.00)*100)));
            //changing the progress bar and labels' visibility
            label3.Visible = true;
            label5.Visible = true;
            progressBar1.Visible = true;
            //making the color of the progress bar depending on the value
            if (progressBar1.Value >= 90 ) { progressBar1.ForeColor = Color.ForestGreen; }
            else if (progressBar1.Value >= 70) { progressBar1.ForeColor = Color.YellowGreen; }
            else if (progressBar1.Value >= 50) { progressBar1.ForeColor = Color.Yellow; }
            else if (progressBar1.Value >= 30) { progressBar1.ForeColor = Color.OrangeRed; }
            else if (progressBar1.Value >= 10) { progressBar1.ForeColor = Color.DarkRed; }
            
        }

        private void button1_Click(object sender, EventArgs e)  //back button clicked
        {
            Program.Back<LetterGraderScreen>();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void LetterGraderScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
