using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89};
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89};
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96};
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] studentNames = new string[] {
    "Sophia",
    "Andrew",
    "Emma",
    "Logan",
    "Becky",
    "Chris",
    "Eric",
    "Gregor",
};

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames) {
    
    string currentStudent = name;

    if (currentStudent == "Sophia")
        // Assign Sophia's scores to the studentScores array
        studentScores = sophiaScores;
    
    else if (currentStudent == "Andrew")
        // Assign Andrew's scores to the studentScores array
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        // Assign Emma's scores to the studentScores array
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        // Assign Logan's scores to the studentScores array
        studentScores = loganScores;
    
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    
    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    // initialize/reset a counter for the number of assignments
    int gradedAssignments = 0;

    // Calculate the extra credit points
    int extraCreditTotal = 0;

    for (int i = examAssignments; i < studentScores.Length; i++) {
        extraCreditTotal += studentScores[i];
        
    }

    foreach(int score in studentScores) {

        // increment  the assignment operator
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        // add the exam score to the sum
        sumAssignmentScores += score;

    } 

    // Calculate the extra credit as 10% of the total extra credit scores
    decimal extraCredit = extraCreditTotal * (0.10m / examAssignments);

    // Calculate the average score
    decimal examScore = (decimal)sumAssignmentScores / examAssignments;

     
     //Calculate the average credit score
    int averageCreditScore = extraCreditTotal / (studentScores.Length - examAssignments);

    // Calculate the overall grade including extra credit
    currentStudentGrade = examScore + extraCredit;

    // Determine Letter Grade
    if(currentStudentGrade >= 97) 
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90) 
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87) 
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83) 
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80) 
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77) 
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73) 
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70) 
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67) 
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63) 
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60) 
        currentStudentLetterGrade = "D-";

    else {
        currentStudentLetterGrade = "F";
    }

    Console.WriteLine($"{currentStudent}\t\t{examScore:F2}\t\t{currentStudentGrade:F2}\t{currentStudentLetterGrade}\t{averageCreditScore} ({extraCredit:F2} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

