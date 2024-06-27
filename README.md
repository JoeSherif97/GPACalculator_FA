# GPA Calculator Application Documentation

## Overview

The GPA Calculator application is a text-based program designed to calculate various GPA metrics based on the GPA system of Future Academy. It includes functionalities to calculate current and cumulative GPA, convert GPA to letter grades, and determine the required GPA for future goals. The application is written in C# and provides a user-friendly interface to manage GPA calculations effectively.

## Features

1. **GPA Calculation**
   - Calculates current semester GPA.
   - Calculates cumulative GPA over multiple semesters.
   - Converts GPA to corresponding letter grades.

2. **Future GPA Calculator**
   - Determines the GPA required in the next semester to achieve a target GPA.

3. **Grade Requirements Calculator**
   - Calculates the average letter grade required in all subjects to reach a specific GPA.
   - Provides guidance on the highest letter grades needed in specific subjects to achieve a desired GPA.

4. **Permitted Hours Calculation**
   - Determines the number of credit hours a student is allowed to take based on their GPA.

5. **Menu and Navigation**
   - Main menu with options for different functionalities.
   - About section with information about the application and its developers.

## Main Components

### Main Menu

Displays the main menu options to the user:
- Calculate GPA
- Determine GPA Letter Grade
- Future GPA Calculator
- Grade Requirements Calculator
- Permitted Hours Calculator
- About
- Exit

### GPA Calculation Functions

1. **Calculate Current GPA (`CGPA`)**
   - Takes a list of points (grades) and credit hours, and calculates the GPA for the current semester.
   - Example: `double CGPA(List<double> P, List<double> H, int s)`

2. **Calculate Cumulative GPA (`AGPA`)**
   - Takes total points and total credit hours, and calculates the cumulative GPA.
   - Example: `double AGPA(double tP, double tH)`

3. **Convert Grade to GPA (`Grade`)**
   - Converts a letter grade to its corresponding numerical GPA value.
   - Example: `double Grade(string letter)`

4. **Convert GPA to Letter Grade (`GGPA`)**
   - Converts a numerical GPA to its corresponding letter grade.
   - Example: `string GGPA(double gpa)`

### Future GPA Functions

1. **Future GPA Calculation (`FGPA`)**
   - Calculates the GPA required in the next semester to achieve a target GPA.
   - Example: `double FGPA(double currentGPA, int totalHours, double targetGPA, int nextSemesterHours)`

2. **Average Grade Calculation (`ASGPA`)**
   - Calculates the average letter grade needed in all subjects to reach a target GPA.
   - Example: `string ASGPA(double targetGPA, int currentHours, double currentGPA, int totalSubjects)`

3. **Target Subject GPA Calculation (`TSGPA`)**
   - Determines the highest letter grade that can be achieved in specific subjects to reach a target GPA.
   - Example: `string TSGPA(double targetGPA, int currentHours, double currentGPA, int specificSubjectHours)`

### Utility Functions

1. **Clear Screen (`Clean`)**
   - Pauses, delays, and clears the terminal screen.
   - Example: `void Clean()`

2. **About Section (`About`)**
   - Displays information about the application and its developers.
   - Example: `void About()`

3. **Exit Function (`Exit`)**
   - Handles user input for exiting the application.
   - Example: `void Exit(ref bool exit, ref bool on, ref char off)`

## Usage Instructions

1. **Start the Application**
   - Run the main function to start the application.

2. **Navigate through the Main Menu**
   - Use the menu options to select the desired functionality.
   - Input the required data when prompted (e.g., GPA values, letter grades, credit hours).

3. **View Results**
   - The application will display the calculated results based on the selected functionality.

4. **Input Method**
   - Enter grades and credit hours using space separation for more efficient input.

## Application Screenshots

### Screenshot Example
#### Main Menu:
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/40df4f31-4448-47c3-a3d3-73ce9fc77c1d)

#### GPA Calculate Function:
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/a1e757f5-a879-43f6-8831-22f59166ab53)

In the example provided in the screenshot:
- The user is prompted to enter the current semester number.
- They are then asked to enter the number of subjects for the semester.
- For each subject, the user inputs the letter grade followed by the credit hours.
- The application calculates and displays the semester GPA, cumulative GPA, and permitted hours for the next semester.

#### Letter Grader Function:
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/6890a04b-4d33-44ad-bb2a-10a49b0ff712)
##### Overview
This feature allows users to input their Grade Point Average (GPA) and receive the corresponding letter grade based on a predefined grading scale.

##### Functionality
###### User Input:
The user is prompted to enter their GPA.
###### GPA Conversion:
The application converts the numeric GPA into a letter grade using a predefined scale.
###### Output:
The application displays the input GPA and its corresponding letter grade.

##### Purpose
This feature helps users quickly determine the letter grade equivalent of their GPA, facilitating a better understanding of their academic performance in a more familiar format.

#### Future GPA Prediction Function: (2 cases)
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/149a24e9-1792-43ce-9c61-2e75525c1589)
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/1b0e6e08-6f05-4751-a315-bf6ebc08e605)

#### Average Grade Calculate Function:
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/a470d817-43e1-438d-aa9e-4599221285f2)

#### Target Subject GPA Calculate Function:
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/e5382ba0-5e21-42e5-9119-f5eda039d005)

#### About:
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/6c8494ff-2542-4244-8966-64126d8e30c4)

## Developers

- **Youssef Sherif**
- **Youssef Muhammed**

This application is designed to assist students at Future Academy in managing their GPA calculations efficiently.

---
