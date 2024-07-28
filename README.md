# GPA Calculator Application Documentation

## Overview

The GPA Calculator application is a text-based (C++/C#) graphical-based (Winform/C#) program designed to calculate various GPA metrics based on the GPA system of Future Academy. It includes functionalities to calculate current and cumulative GPA, convert GPA to letter grades, and determine the required GPA for future goals. The application is written in C# and provides a user-friendly interface to manage GPA calculations effectively.

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
#### including text-based and graphical-based screenshots

### Screenshot Example
#### Loading Screen:
![image](https://github.com/user-attachments/assets/39a167c9-1193-4520-b281-39cb556c421d)

#### Main Menu:
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/40df4f31-4448-47c3-a3d3-73ce9fc77c1d)
![image](https://github.com/user-attachments/assets/fba67180-96e9-4530-9450-b2dddef4e818)

#### GPA Calculate Function:
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/a1e757f5-a879-43f6-8831-22f59166ab53)
![image](https://github.com/user-attachments/assets/68bee6fb-f695-4865-bbeb-d5b1c518ea48)

In the example provided in the screenshot:
- The user is prompted to enter the current semester number.
- They are then asked to enter the number of subjects for the semester.
- For each subject, the user inputs the letter grade followed by the credit hours.
- The application calculates and displays the semester GPA, cumulative GPA, and permitted hours for the next semester.

##### Statistics:
![image](https://github.com/user-attachments/assets/a81de382-e2ec-4272-a85b-eb4b3ac4af7a)

##### Entering New Semester:
![image](https://github.com/user-attachments/assets/7e947c23-2979-4671-ac8c-9147ae6cab2f)
![image](https://github.com/user-attachments/assets/1db2b09d-594b-49bc-aaf7-dca72e7c8013)

##### Finished All Semester MessageBox:
![image](https://github.com/user-attachments/assets/de5eab56-5094-4588-a233-558444feb538)

#### Letter Grader Function:
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/6890a04b-4d33-44ad-bb2a-10a49b0ff712)
![image](https://github.com/user-attachments/assets/128a78f7-ea84-4d00-a082-ae139abe61a0)

##### Overview
This feature allows users to input their Grade Point Average (GPA) and receive the corresponding letter grade based on a predefined grading scale.

##### Functionality
###### User Input:
The user is prompted to enter their GPA.
###### GPA Conversion:
The application converts the numeric GPA into a letter grade using a predefined scale.
###### Output:
- The application displays the input GPA and its corresponding letter grade.
- How much you can present your GPA in Percentage
- Percentage presented in Progress Bar with different colors for differnt scores

##### Purpose
This feature helps users quickly determine the letter grade equivalent of their GPA, facilitating a better understanding of their academic performance in a more familiar format.

#### Future GPA Prediction Function: (2 cases)
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/149a24e9-1792-43ce-9c61-2e75525c1589)
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/1b0e6e08-6f05-4751-a315-bf6ebc08e605)
![image](https://github.com/user-attachments/assets/ae611e1d-62bf-485e-9f9c-742335de8b34)

### Feature Overview

**Functionality and Purpose:**

1. **Enter Current and Target GPA:**
   - **Overview:** This feature allows users to input their current GPA and the target GPA they aim to achieve. The program then calculates the GPA needed in the next semester to reach the target GPA.
   - **Functionality:**
     - **User Input:** The user is prompted to enter their current GPA and the desired GPA.
     - **Calculation:** The program calculates whether the target GPA is achievable in one semester.
     - **Output (Case 1):** If the target GPA is achievable, the program provides the required GPA for the next semester.
       - **Example:** With a current GPA of 2.6 and a target GPA of 2.8, the program suggests an estimated GPA of 3.0 for the next semester.
     - **Output (Case 2):** If the target GPA is not achievable in one semester, the program informs the user and provides an alternative achievable GPA.
       - **Example:** With a current GPA of 2.6 and a target GPA of 3.5, the program indicates that the target cannot be reached in one semester. It suggests that if the user achieves a GPA of 4.0 next semester, the new GPA will be 3.3.
   - **Purpose:** This feature helps students set realistic academic goals by understanding the GPA they need to achieve in the upcoming semester to reach their overall GPA targets. It also provides a sense of achievable goals when the desired GPA is too high to be attained in one semester.

#### Average Grade Calculate Function:
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/a470d817-43e1-438d-aa9e-4599221285f2)
![image](https://github.com/user-attachments/assets/88f1b819-5bd8-40fb-ac3a-ed7cb7bf2f12)

### Feature Overview

**Functionality and Purpose:**

1. **Enter Current GPA and Target GPA to Determine Required Average Letter Grade:**
   - **Overview:** This feature allows users to input their current GPA and the GPA they aim to achieve. The program calculates the average letter grade the user needs to obtain in their subjects next semester to reach the target GPA.
   - **Functionality:**
     - **User Input:** The user enters their current GPA and the desired GPA.
     - **Calculation:** The program computes the average letter grade required in the next semester to achieve the target GPA.
     - **Output:** The program informs the user of the necessary average letter grade to reach their target GPA.
       - **Example:** With a current GPA of 2.6 and a target GPA of 3.0, the program indicates that the user needs to achieve an average grade of A- in their subjects next semester to reach the target GPA.
   - **Purpose:** This feature assists students in understanding the level of academic performance required in the upcoming semester to achieve their GPA goals. It provides clear guidance on the average letter grade needed, helping students set realistic expectations and plan their study efforts accordingly.

#### Target Subject GPA Calculate Function:
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/e5382ba0-5e21-42e5-9119-f5eda039d005)
![image](https://github.com/user-attachments/assets/9d85fa7f-4789-4d9b-9c6a-855b1b9a1058)

#### Feature Overview

**Functionality and Purpose:**

2. **Enter Number of Subjects, Current GPA, and Target GPA to Determine Required Grades:**
   - **Overview:** This feature enables users to input the number of subjects they will take in the next semester, along with their current GPA and desired GPA. The program calculates the specific grades needed in each subject to achieve the target GPA, assuming all subjects have the same credit hours.
   - **Functionality:**
     - **User Input:** The user enters:
       - The number of subjects for the next semester.
       - Their current GPA.
       - The GPA they aim to achieve.
     - **Calculation:** The program computes the required grades for each subject to reach the desired GPA.
     - **Output:**
        - The program displays the minimum grade required for each subject to achieve the target GPA.
        - if the GPA wished is on specific level, the application will tell the user if he has any any-grade subjects
     - **Example:** With 6 subjects, a current GPA of 2.6, and a target GPA of 3.0, the program specifies the necessary grades for each subject, such as A+ for most subjects and a D- for one subject, to reach a GPA of 3.4.
   - **Purpose:** This feature helps students understand the specific academic performance needed in each subject to reach their GPA goals. It provides clear and actionable insights, allowing students to strategize their study efforts and focus on achieving the necessary grades in each subject.

#### About:
![image](https://github.com/JoeSherif97/GPACalculator_FA/assets/138067777/6c8494ff-2542-4244-8966-64126d8e30c4)
![image](https://github.com/user-attachments/assets/f1a8f5ce-aaba-4a5f-8463-eef5fc62da16)

#### Exit Screen:
![image](https://github.com/user-attachments/assets/33090055-4fa3-45bd-a4b3-9c5451a84512)

##### Cases:
###### No:
It will show this MessageBox then return the user to the main screen
![image](https://github.com/user-attachments/assets/4df3cd0f-92a1-415d-8e8f-fe70fab9e0c5)

###### Yes:
It will show 2 corresponding MessageBoxes:
![image](https://github.com/user-attachments/assets/5ff5e029-9e8a-4b7d-807f-bdaab63798ce)
![image](https://github.com/user-attachments/assets/e9f96a9d-2ba3-4e65-8eee-8807779c9223)
Then Exit The Program.

## Developers

- **Youssef Sherif**
- **Youssef Muhammed**

This application is designed to assist students at Future Academy in managing their GPA calculations efficiently.

---
