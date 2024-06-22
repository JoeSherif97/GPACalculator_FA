// GPA Calculator Future prototype.cpp : This file contains the 'main' function. Program execution begins and ends there.
//Day 1 Finished, Summary: 60 lines of code, made the initial variables, made clean function, made question about entering semster & subject nb & grade & credit hour, finished 4/5/24 07:05 am
//Day 2 Finished, Summary: 148 lines of code, made other variables, added additional libaries, made additional functions, optimized the memory and entering the values, made a statistics panel to show gpa, credit hour and pos, finished 4/6/24 12:29 am
//Day 3 Finished, Summary: 218 lines of code, made the last variables, added more functions, finished the app succesfuly 4/6/24 5:37 am
//Day 4 Finished, Summary: 251 lines of code, made all the program function, added main menu, 5/6/24 8:17 pm

//Libaries
#include <iostream>
#include <cstdlib>
#include <vector>
#include <utility>

using namespace std;

//Functions
void clean() {
	system("PAUSE");
	system("cls");
} //Function to pause and delay the terminal
void MainMenu() {
	system("cls");
	cout << "=====================================================================\n";
	cout << "Welcome To Future Academy GPA Calculator :)\n";
	cout << "What do you want to do?\n";
	cout << "1.Calculate Your GPA\n2.About\n3.Exit\nYour Choice:";
}
void About() {
	system("cls");
	cout << "About Us\nThis is a text-based program that is responsible of calculating your current and accumulative GPA based on the GPA system of future academy, And also Calculate how many credit hour can you take next semester, designed by Youssef Sherif.\nHelped by Youssef MUhammed\n";
	clean();
}
void Exit(bool& exit,bool& on,char& off) {
	system("cls");
	while (exit) {
		try {
			cout << "Do you want to exit the App? (y/n): ";
			cin >> off;
			if (!((off == 'y') || (off == 'n') || (off == 'Y') || (off == 'N'))) { throw off; }
		}
		catch (char off) {
			cout << "\nInvalid input, enter either y/Y or n/N\n";
			clean();
		};

		if (off == 'y' || off == 'Y') {
			on = false;
			exit = false;
			clean();
		}
		else {
			on = true;
			exit = false;
		};
	}
}
double Grade(string letter) {
	switch (letter.at(0)) {
	case 'A':
		if (letter.length() == 1) {
			return 3.7;
		}
		else if (letter.at(1) == '+') {
			return 4.0;
		}
		else if (letter.at(1) == '-') {
			return 3.4;
		}
		break;
	case 'B':
		if (letter.length() == 1) {
			return 3.0;
		}
		else if (letter.at(1) == '+') {
			return 3.2;
		}
		else if (letter.at(1) == '-') {
			return 2.8;
		}
		break;
	case 'C':
		if (letter.length() == 1) {
			return 2.4;
		}
		else if (letter.at(1) == '+') {
			return 2.6;
		}
		else if (letter.at(1) == '-') {
			return 2.2;
		}
		break;
	case 'D':
		if (letter.length() == 1) {
			return 1.5;
		}
		else if (letter.at(1) == '+') {
			return 2.0;
		}
		else if (letter.at(1) == '-') {
			return 1.0;
		}
		break;
	case 'F':
		return 0;
		break;
	default:
		return 0;
		break;
	}
	return 0;
}
double CGPA(vector<double> P, vector<double> H, int s) {
	double cgpa = (P.at(s - 1) / H.at(s - 1));
	float n = ceil(cgpa) - cgpa;
	n = (1 - n) * 100;
	int l = n;
	n = float(l) / 100;
	float I = floor(cgpa) + n;
	return I;
}
double AGPA(double tP, double tH) {
	double agpa = (tP / tH);
	float n = ceil(agpa) - agpa;
	n = (1 - n) * 100;
	int l = n;
	n = float(l) / 100;
	float I = floor(agpa) + n;
	return I;
}
double Permitted(double gpa) {
	if (gpa >= 3.0) {
		return 21;
	}
	else if (gpa < 3.0 && gpa >= 2.0) {
		return 18;
	}
	else if (gpa < 2.0 && gpa >= 1.0) {
		return 15;
	}
	else if (gpa < 1.0 && gpa >= 0) {
		return 12;
	}
	else {
		return 0;
	}
	return 0;
}
void Statistics(vector<double> &SP,vector<double> &SH,int &Sems,double &TH,double &TP) {
	cout << "Semster " << Sems << " Statistics:\n";
	cout << "" << Sems << " Semster Sum of PoS is " << SP.at(Sems - 1) << endl;
	cout << "" << Sems << " Semster Credit hours are " << SH.at(Sems - 1) << endl;
	cout << "" << Sems << " Semster GPA is " << CGPA(SP, SH, Sems) << endl;
	cout << "----------------------------------------------------------------------" << endl;
	TH += SH.at(Sems - 1);
	TP += SP.at(Sems - 1);
	
	cout << "" << Sems << " Permitted Hours for your next Semster are " << Permitted(CGPA(SP, SH, Sems)) << endl;
	cout << "" << Sems << " Total Credit hours are " << TH << endl;
	cout << "" << Sems << " Accumulative GPA is " << AGPA(TP, TH) << endl;
	clean();
	Sems++;
}
void Calculate(int& Sem, int& Semster, int& SubjectNb, double& Hr, double& TotalHour, double& TotalPoS, string& St, vector<double>& Hours, vector<string>& Subjects, vector<pair<string, double>>& Subj, vector<double>& PoS, vector<double>& SumPoS, vector<double>& SumHour) {
	system("cls");
	//Asking About your term
		cout << "What is your current Semster number: ";
		try
		{
			cin >> Semster;
			if (Semster < 0) { throw(Semster); };
		}
		catch (int Semster)
		{
			cout << "Enter a valid Semester Number >:( ";
			clean();
		}
		for (int i = 0; i < Semster; i++) {
			//Asking about how many subject do you have on this semster
			cout << "\nEnter how many subjects do you have in this semster " << i + 1 << " : ";
			try {
				cin >> SubjectNb;
				if (SubjectNb < 0) { throw SubjectNb; };
			}
			catch (int SubjectNb) {
				cout << "Enter a valid Number of Subject number >:( ";
				clean();
			}
			Subjects.clear();
			Hours.clear();
			PoS.clear();
			Subj.clear();


			cout << "\nEnter your Subject letter grade(A+,A,A-,B+,B,B-,C+,C,C-,D+,D,D-,F) and the subject credit hour ";
			//Asking what are your letter grade and what are the credit hours for these grades
			for (int j = 0; j < SubjectNb; j++) {
				cout << "\nEnter Subject Nb " << j + 1 << ": ";
				cin >> St >> Hr;
				Subjects.push_back(St);
				Hours.push_back(Hr);
				Subj.push_back(make_pair(Subjects.at(j), Hours.at(j)));
				//cout << "Subject Nb " << j + 1 << " grade: " << Subj.at(j).first << " credit hour: " << Subj.at(j).second;
			}

			//Calculating Points of Subject and credit hours Calculating
			for (int k = 0; k < SubjectNb; k++) {
				PoS.push_back(Grade(Subj.at(k).first) * Subj.at(k).second);
				//cout << PoS.at(k) << endl;
				if (k == 0) {
					SumPoS.push_back(PoS.at(k));
					SumHour.push_back(Subj.at(k).second);
				}
				else {
					SumPoS.at(Sem - 1) += PoS.at(k);
					SumHour.at(Sem - 1) += Subj.at(k).second;
				}
			}

			//Showing Semster Statistics
			Statistics(SumPoS, SumHour, Sem, TotalHour, TotalPoS);
		}

}

int main()
{
//Define Area
	int Sem = 1; //Sem is an int that traverse the vector to reach Semster 
	int Semster	= 0; //Semster is a solid number that will most probably be in range between 1 to 8
	int SubjectNb = 0;	//Subject Number is how many Subject you had in the i-th Semster
	double Hr=0;//temp for taking the input from the user
	string St=" ";//temp for taking the input from the user
	vector<double> Hours; //array to store nb of hours
	Hours.reserve(32);//pre-allocate 32 pair for the vector
	vector<string> Subjects; //array to store the subjects grades
	Subjects.reserve(32);//pre-allocate 32 pair for the vector
	vector<pair<string, double>> Subj;//vector pair to store the letter grade and the credit hour
	Subj.reserve(32);//pre-allocate 32 pair for the vector
	vector<double> PoS;//vector the store the point of subject for each subject
	PoS.reserve(32);//pre-allocate 32 slot for the vector
	vector<double> SumPoS;//vector to store the Sum of Pos
	SumPoS.reserve(32);//pre-allocate 32 slots to store all the Sum of Pos
	vector<double> SumHour;//vector to store all credit hour of the subject
	SumHour.reserve(32);//pre-allocate 32 slots to store all the sum of credit hours
	double TotalHour = 0;//temp for storing the accumulative data
	double TotalPoS = 0;//temp for storing the accumulative data
	char off=' ';//char storage for turning off the app
	char menu;//char to choose menu option
	bool exit = true; //exit is an bool var to keep the exit function working
	bool on = true;	//On is an bool var to keep the app working

//Making an active loop to keep the app working until i say it stops
	do {
		MainMenu();
		cin >> menu;
		if (menu == '1') {
			Calculate(Sem, Semster, SubjectNb, Hr, TotalHour, TotalPoS, St, Hours, Subjects, Subj, PoS, SumPoS, SumHour);
		}
		else if (menu == '2') {
			About();
		}
		else if (menu == '3') {
			Exit(exit, on, off);
		}
	} while (on);
	cout << "--------------------------------\nThanks for using my app :)\n--------------------------------\n";
	system("PAUSE");
}






// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
