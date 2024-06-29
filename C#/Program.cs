// GPA Calculator Future prototype C# edition.cs : This file contains the 'main' function. Program execution begins and ends there.
//Day 1: Finished transforming of define Area from C++ to C# while changing vector to list, and pair to tuple, and removing the pre-allocate; 12/6/2024
//Day 2: Finished Transforming my app to C#, and added features like GGPA,FGPA,ASGPA,TSGPA which are different calculators that do multiple things; 17/6/2024 :: 2:00 am =>> 8:15 am 

//directives
using System;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace GPA_Calculator_Csharpy;

class Program
{
    //Functions
    static void Clean() //Function to Pause and delay then delete the terminal screen
    {
        Console.ReadKey();
        Console.Clear();
    }

    static void MainMenu()  //Function to show the Main Menu Options to the user
    {
        Console.Clear();
        Console.WriteLine("=====================================================================\n");
        Console.WriteLine("Welcome To Future Academy GPA Calculator :)\n");
        Console.WriteLine("What Do you want to do?\n");
        Console.WriteLine("1.Calculate Your GPA \n2.What is Your GPA's Letter Grade \n3.Future GPA Calculator   \n4.What Grades Should I Get Calculator \n5.At leaster Calculator   \n6.About   \n7.Exit    \nYour Choice:");
    }

    static void About() //Function to show About Us to user
    {
        Console.Clear();
        Console.WriteLine("About Us \nThis is a text-based program that is responsible of calculating your current and accumulative GPA based on the GPA system of future academy,  \nAnd also Calculate how many credit hour can you take next semester,   \ndesigned by Youssef Sherif.\nHelped by Youssef Muhammed\n");
        Clean();
    }

    static void Exit(ref bool exit, ref bool on, ref char off)    //Function to take the var off sent by the user to exit the grand loop and close the program
    {
        Console.Clear();
        do
        {
            try
            {
                Console.WriteLine("Do you want to exit the app? (y/Y for yes & n/N for No):");
                off = Convert.ToChar(Console.ReadLine().ToLower());
                if (!((off == 'y') || (off == 'n'))) { throw new Exception("Invalid Input"); };
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid Input, enter either y/Y or n/N\n");
                Clean();
            }
            if (off == 'y')
            {
                on = false;
                exit = false;
                Clean();
            }
            else
            {
                on = true;
                exit = false;
            }

        }
        while (exit);
    }

    static double Grade(string letter)  //Functon to transform the letter grade to numerical value
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

    static string GGPA()    //Function to show the user what is the letter grade of their GPA
    {
        Console.Clear();
        Console.WriteLine("Enter Your GPA: ");
        double GPA = Convert.ToDouble(Console.ReadLine());
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

    static string GGPA(double GPA)    //Function to Return the user what is the letter grade of their GPA based on a parameter
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

    private static double CurrentGPA;
    private static double FutureGPA;
    private static double EstimatedGPA = (2 * FutureGPA) - CurrentGPA;
    private static double MaximumGPA = (4 + CurrentGPA) / 2;

    static string FGPA()    //Function to Calculate How Much GPA you must Get To Achieve a Certain GPA
    {
        Console.Clear();
        Console.WriteLine("Enter Your GPA and Enter The GPA you want to reach to see what Aproximtly GPA you must get next semester: ");
        CurrentGPA = Convert.ToDouble(Console.ReadLine());
        FutureGPA = Convert.ToDouble(Console.ReadLine());
        EstimatedGPA = (2 * FutureGPA) - CurrentGPA;
        MaximumGPA = (4 + CurrentGPA) / 2;
        if (EstimatedGPA > 4) return ("You Cannot Reach this GPA by Next Semester, But If you Get GPA of 4 Next Semester, You will reach GPA of " + Convert.ToString(Math.Round(MaximumGPA, 3)));
        else return ("You will need An Estimated GPA of " + Convert.ToString(Math.Round(EstimatedGPA, 3)) + " to reach this GPA " + FutureGPA.ToString());
    }

    static string ASGPA()  //Function to tell you what is The Average Letter Grade you must get in all of the Subjects to reach a certain GPA
    {
        Console.Clear();
        Console.WriteLine("Enter Your GPA and GPA you want to reach to Get THe Average Letter Grade You must get in your Subjects To Reach that GPA: ");
        CurrentGPA = Convert.ToDouble(Console.ReadLine());
        FutureGPA = Convert.ToDouble(Console.ReadLine());
        EstimatedGPA = (2 * FutureGPA) - CurrentGPA;
        MaximumGPA = (4 + CurrentGPA) / 2;
        if (EstimatedGPA > 4.0) return ("You Cannot Reach this GPA by Next Semester,\nBut If you get " + GGPA(MaximumGPA) + " in your Subjects Next Semester, You will reach GPA of " + Convert.ToString(Math.Round(MaximumGPA, 3)));
        else return ("You will need to get " + GGPA(EstimatedGPA) + " in your Subjects Next Semester to reach this GPA of " + FutureGPA.ToString());
    }

    static void TSGPA()   //Function to tell what are the highest letter grade you can get in specific Nb of Subjects to reach a specific GPA
    {
        Console.Clear();
        Console.WriteLine("Enter The Number of Subject you will have next Semester,\nAnd your Cureent GPA, and The GPA you want to achive,\nto get what grades should you get in most of your subjects (in case all your Subjects had the Same credit hours): ");
        int SubjectsNumber = Convert.ToInt32(Console.ReadLine());
        CurrentGPA = Convert.ToDouble(Console.ReadLine());
        FutureGPA = Convert.ToDouble(Console.ReadLine());
        EstimatedGPA = (2 * FutureGPA) - CurrentGPA;
        MaximumGPA = (4 + CurrentGPA) / 2;
        List<string> Subjects = new List<string>(SubjectsNumber);
        int counter = 1;
        if (EstimatedGPA > 4.0)
        {
            double Weight = MaximumGPA * SubjectsNumber;
            while (Weight > 0)
            {
                double PlaceHolder = Grade(GGPA(Weight));
                Subjects.Add(GGPA(Weight));
                Weight -= PlaceHolder;
            }
            Console.WriteLine("you must get at least ");
            while (Subjects.Any())
            {
                Console.WriteLine("Subject Number " + counter + " : " + Subjects.First());
                Subjects.RemoveAt(0);
                counter++;
            }
            Console.WriteLine("to reach this GPA of " + Math.Round(MaximumGPA, 3));
            Clean();
        }
        else
        {
            double Weight = EstimatedGPA * SubjectsNumber;
            while (Weight > 0)
            {
                double PlaceHolder = Grade(GGPA(Weight));
                Subjects.Add(GGPA(Weight));
                Weight -= PlaceHolder;
            }
            Console.WriteLine("you must get at least ");
            while (Subjects.Any())
            {
                Console.WriteLine("Subject Number " + counter + " : " + Subjects.First());
                Subjects.RemoveAt(0);
                counter++;
            }
            Console.WriteLine("to reach this GPA of " + Math.Round(EstimatedGPA, 3));
            Clean();
        };
    }

    static double CGPA(List<double> P, List<double> H, int s) //Function to return the current semester GPA
    {
        double cgpa = (P[s - 1] / H[s - 1]);
        return cgpa;
    }

    static double AGPA(double tP, double tH) //Function to return the Accumalative GPA
    {
        double agpa = (tP / tH);
        return Math.Truncate(agpa * 100) / 100;
    }

    static double Permitted(double gpa) //Function to return the permitted number of hour that the student can take depends on the gpa
    {
        if (gpa >= 3.0) return 21;
        else if (gpa < 3.0 && gpa >= 2.0) return 18;
        else if (gpa < 2.0 && gpa >= 1.0) return 15;
        else if (gpa < 1.0 && gpa >= 0) return 12;
        else return 0;
    }

    static void Statistics(ref List<double> SP, ref List<double> SH, ref int Sems, ref double TH, ref double TP)    //Function to show the user the statistics of permitted,AGPA,CGPA Analytics
    {
        Console.WriteLine("Semester" + Sems + " Statistics:\n");
        //Console.WriteLine(Sems + "th Semester Sum of PoS is " + SP[Sems - 1] + "\n");
        Console.WriteLine(Sems + "th Semester Credit Hours are " + SH[Sems - 1] + "\n");
        Console.WriteLine(Sems + "th Semester GPA is " + CGPA(SP, SH, Sems) + "\n");
        Console.WriteLine(Sems + "th Semester Letter Grade is " + GGPA(CGPA(SP, SH, Sems)) + "\n");
        Console.WriteLine("------------------------------------------------------------\n");
        TH += SH[Sems - 1];
        TP += SP[Sems - 1];
        Console.WriteLine("Accumalative Statistics:\n");
        Console.WriteLine("Total Credit Hours are " + TH + "\n");
        Console.WriteLine("Accumulative GPA is " + AGPA(TP, TH) + "\n");
        Console.WriteLine("Permitted Hours for your next semester are " + Permitted(CGPA(SP, SH, Sems)) + "\n");
        Console.WriteLine("The Letter Grade of Your Accumalative GPA is " + GGPA(AGPA(TP, TH)) + "\n");
        if (AGPA(TP, TH) <= 2.0) { Console.WriteLine("Take Care, If Your Accumalative GPA Stayed Equal to 2.0 or Less For More Than 4 Semesters, You will be Terminated"); };
        Clean();
        Sems++;
    }

    static void Calculate(ref int Sem, ref int Semester, ref int SubjectNb, ref double Hr, ref double TotalHour, ref double TotalPoS, ref string St, ref List<double> Hours, ref List<string> Subjects, ref List<Tuple<string, double>> Subj, ref List<double> PoS, ref List<double> SumPoS, ref List<double> SumHour) //Function that do all the calculation
    {
        Console.Clear();
        //Asking about your term number
        Console.WriteLine("What is your Current Semester number: ");
        try
        {
            Semester = Convert.ToInt32(Console.ReadLine());
            if (Semester < 0) throw new Exception("Invalid Semster Number");
        }
        catch (Exception)
        {
            Console.WriteLine("Enter a Valid Semester Number >:( ");
            Clean();
        }
        for (int i = 0; i < Semester; i++)
        {
            Console.WriteLine("\nEnter how many subjects do you have in this semster:");
            //Asking about how many Subjects did you have this Semester
            try
            {
                SubjectNb = Convert.ToInt32(Console.ReadLine());

                if (SubjectNb < 0) throw new Exception("Invalid Number of Subjects");
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a valid Number of Subject Number >:( ");
                Clean();
            }

            //Clearing the Lists
            Subjects.Clear();
            Hours.Clear();
            PoS.Clear();
            Subj.Clear();

            //Asking what is your letter grade & what are the credit hour for each Subject
            Console.WriteLine("\nEnter your Subject letter grade(A+,A,A-,B+,B,B-,C+,C,C-,D+,D,D-,F) and the subject credit hour ");
            for (int j = 0; j < SubjectNb; j++)
            {
                Console.WriteLine("Enter Subject Number " + (j + 1) + ": ");
                St = Console.ReadLine().ToUpper();
                Hr = double.Parse(Console.ReadLine());
                Subjects.Add(St);
                Hours.Add(Hr);
                Subj.Add(new Tuple<string, double>(Subjects[j], Hours[j]));
                //Console.WriteLine("Subject Number "+(j+1)+" grade: "+Subj[j].Item1+" credit hour: "+Subj[j].Item2);
            }

            //Calculating Points of Subjects and credit hours
            for (int k = 0; k < SubjectNb; k++)
            {
                PoS.Add(Grade(Subj[k].Item1) * Subj[k].Item2);
                //Console.WriteLine(PoS[k]+"\n");
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

            //Showing Semster Statistics
            Statistics(ref SumPoS, ref SumHour, ref Sem, ref TotalHour, ref TotalPoS);
        }

    }

    static void Main(string[] args)
    {
        //Define Area
        int Sem = 1; //Sem is an int that traverse the vector to reach Semster
        int Semester = 0; //Semester is a solid number that will most probably be in range between 1 to 8
        int SubjectNb = 0; //Subject Number is how many Subject you had in the i-th Semster
        double Hr = 0; //temp for taking the input from the user
        string St = " "; //temp for taking the input from the user
        List<double> Hours = new List<double>(); //List to store nb of hours
        List<string> Subjects = new List<string>(); //List to store the subjects grades
        List<Tuple<string, double>> Subj = new List<Tuple<string, double>>(); //List Tuple to store the letter grade and the credit hour
        List<double> PoS = new List<double>();//List the store the point of subject for each subject
        List<double> SumPoS = new List<double>();//List to store the Sum of Pos
        List<double> SumHour = new List<double>();//List to store all credit hour of the subject
        double TotalHour = 0;//temp for storing the accumulative data
        double TotalPoS = 0;//temp for storing the accumulative data
        char off = ' ';//char storage for turning off the app
        char menu;//char to choose menu option
        bool exit = true; //exit is an bool var to keep the exit function working
        bool on = true; //On is an bool var to keep the app working

        //Making an Active loop to keep the app working until i say it stops
        do
        {
            MainMenu();
            menu = Convert.ToChar(Console.ReadLine());
            switch (menu) {
            case '1':
                Calculate(ref Sem, ref Semester, ref SubjectNb, ref Hr, ref TotalHour, ref TotalPoS, ref St, ref Hours, ref Subjects, ref Subj, ref PoS, ref SumPoS, ref SumHour);
                break;
            case '2':
                Console.WriteLine("Your GPA has the Letter Grade of " + GGPA());
                Clean();
                break;
            case '3':
                Console.WriteLine(FGPA());
                Clean();
                break;
            case '4':
                Console.WriteLine(ASGPA());
                Clean();
                break;
            case '5':
                TSGPA();
                break;
            case '6':
                About();
                break;
            case '7':
                Exit(ref exit, ref on, ref off);
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
            };
            
        }
        while (on);
        Console.WriteLine("--------------------------------\nThanks for using my app :)\n--------------------------------\n");
        Console.ReadKey();
    }
}
