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
    public partial class SplashScreen : Form
    {
        //making a timer and a progress value
        private Timer timer;
        private int progressValue;

        public SplashScreen()
        {
            InitializeComponent();
            InitializeProgressBar();
        }

        private void InitializeProgressBar()    //function the make the progress bar animation setting
        {
            //setting the progress bar min, max, value
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            //making new timer, setting its interval to 40 millisecond
            timer = new Timer();
            timer.Interval = 40;
            timer.Tick += Timer_Tick;

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //setting the progress bar value to zero, and startng the timer
            progressValue = 0;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) //function to progressly increment the progress bar then close the screen
        {
            progressValue += 1;
            progressBar1.Value = progressValue;
            if ((progressValue >= 100)) //when the progress bar reach 100, stop the timer and close the screen
            {
                timer.Stop();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_ForeColorChanged(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
