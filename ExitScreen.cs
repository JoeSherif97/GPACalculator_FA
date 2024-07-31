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
    public partial class ExitScreen : Form
    {
        private int yesCounter = 0; //counter to torture the user to forcefully make him click 3 times on exit and 2 ok buttons to exit the app
        public ExitScreen()
        {
            InitializeComponent();
        }

        private void ExitScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)  //yes button clicked
        {
            if (yesCounter == 0)    //if clicked once dislay this
            {
                MessageBox.Show("ARE YOU SUREEEE???????????");
                yesCounter++;
            }
            else if (yesCounter == 1)   //if clicked twice press that
            {
                MessageBox.Show("Please My Friend");
                yesCounter++;
            }
            else   //if clicked for the third time, close the app and end his suffering
            {
                Application.Exit();
            }
        }
        private void button2_Click(object sender, EventArgs e)  //No button clicked
        {
            MessageBox.Show("My Friend, You are the Best"); //gratitude message
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) => Program.Back<ExitScreen>();
    }
}
