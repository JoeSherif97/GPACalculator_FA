using System;
using System.Linq;
using System.Windows.Forms;

namespace GPA_Calculator_FA_CSharpy
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            //showing loading screen before the program starts
            using (SplashScreen splashScreen = new SplashScreen())
            {
                splashScreen.ShowDialog();
            }
            
            //launching the main screen
            Application.Run(new MainScreen());
        }


        public static void OpenForm<T>() where T : Form, new()  //function to open a window while checking if there any instance open ( close the old and start a new one ) else ( open the window ) 
        {
            T form = Application.OpenForms.OfType<T>().FirstOrDefault();
            if (form != null) //if an instance is actively open, close it
            {
                form.Close();
            }
            form = new T();
            form.Show();
        }

        public static void Back<T>() where T : Form, new()  //function to go back to the main screen
        {
            T form = Application.OpenForms.OfType<T>().FirstOrDefault();
            if (form != null)
            {
                form.Close();
            }
            MainScreen form1 = new MainScreen();
            form1.Show();
        }

        public static string GGPA(double GPA)    //Function to Return the user what is the letter grade of their GPA based on a parameter
        {
            if (GPA == 0.0) return "F";
            else if (GPA > 0.0 && GPA <= 1.0) return "D-";
            else if (GPA > 1.0 && GPA <= 1.5) return "D";
            else if (GPA > 1.5 && GPA <= 2.0) return "D+";
            else if (GPA > 2.0 && GPA <= 2.2) return "C-";
            else if (GPA > 2.2 && GPA <= 2.4) return "C";
            else if (GPA > 2.4 && GPA <= 2.6) return "C+";
            else if (GPA > 2.6 && GPA <= 2.8) return "B-";
            else if (GPA > 2.8 && GPA <= 3.0) return "B";
            else if (GPA > 3.0 && GPA <= 3.2) return "B+";
            else if (GPA > 3.2 && GPA <= 3.4) return "A-";
            else if (GPA > 3.4 && GPA <= 3.7) return "A";
            else if (GPA > 3.7 && GPA <= 4.0) return "A+";
            else return "A+";
        }

        public static double Grade(string letter)  //Functon to transform the letter grade to numerical value
        {
            if (letter.Length == 1)
            {
                switch (letter[0])
                {
                    case 'A':
                        return 3.7;
                    case 'B':
                        return 3.0;
                    case 'C':
                        return 2.4;
                    case 'D':
                        return 1.5;
                    case 'F':
                        return 0.0;
                    default: return 0;
                }
            }
            else if (letter.Length > 1)
            {
                switch (letter[1])
                {
                    case '+':
                        switch (letter[0])
                        {
                            case 'A':
                                return 4.0;
                            case 'B':
                                return 3.2;
                            case 'C':
                                return 2.6;
                            case 'D':
                                return 2.0;
                        }
                        break;
                    case '-':
                        switch (letter[0])
                        {
                            case 'A':
                                return 3.4;
                            case 'B':
                                return 2.8;
                            case 'C':
                                return 2.2;
                            case 'D':
                                return 1.0;
                        }
                        break;
                    default: return 0;
                }
            }
            return 0;
        }
    }
}
