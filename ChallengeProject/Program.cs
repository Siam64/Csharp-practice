﻿int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\t\tOverall Score\t\tLetter Grade\t\tImpact\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;
    decimal extra = 0;
    int extraCredit = 0;
    decimal ecn = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;
        else
        {
            extra += score / 10.0m; ;
            extraCredit += 1;  
            ecn= (extra/extraCredit)*10;
        }
            

    }

 
    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;
    decimal pts = (decimal)(extra) / examAssignments;
    decimal withextra = (decimal)(sumAssignmentScores + extra) / examAssignments;

    if (withextra >= 97)
        currentStudentLetterGrade = "A+";
    else if (withextra >= 93)
        currentStudentLetterGrade = "A";
    else if (withextra >= 90)
        currentStudentLetterGrade = "A-";
    else if (withextra >= 87)
        currentStudentLetterGrade = "B+";
    else if (withextra >= 83)
        currentStudentLetterGrade = "B";
    else if (withextra >= 80)
        currentStudentLetterGrade = "B-";
    else if (withextra >= 77)
        currentStudentLetterGrade = "C+";
    else if (withextra >= 73)
        currentStudentLetterGrade = "C";
    else if (withextra >= 70)
        currentStudentLetterGrade = "C-";
    else if (withextra >= 67)
        currentStudentLetterGrade = "D+";
    else if (withextra >= 63)
        currentStudentLetterGrade = "D";
    else if (withextra >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t\t{withextra}\t\t\t{currentStudentLetterGrade}\t\t\t{ecn}({pts} pts)");
}
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();






















//using System;

//// initialize variables - graded assignments 
//int currentAssignments = 5;

//int sophia1 = 90;
//int sophia2 = 86;
//int sophia3 = 87;
//int sophia4 = 98;
//int sophia5 = 100;

//int andrew1 = 92;
//int andrew2 = 89;
//int andrew3 = 81;
//int andrew4 = 96;
//int andrew5 = 90;

//int emma1 = 90;
//int emma2 = 85;
//int emma3 = 87;
//int emma4 = 98;
//int emma5 = 68;

//int logan1 = 90;
//int logan2 = 95;
//int logan3 = 87;
//int logan4 = 88;
//int logan5 = 96;

//int sophiaSum = 0;
//int andrewSum = 0;
//int emmaSum = 0;
//int loganSum = 0;

//decimal sophiaScore;
//decimal andrewScore;
//decimal emmaScore;
//decimal loganScore;

//sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
//andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
//emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
//loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

//sophiaScore = (decimal)sophiaSum / currentAssignments;
//andrewScore = (decimal)andrewSum / currentAssignments;
//emmaScore = (decimal)emmaSum / currentAssignments;
//loganScore = (decimal)loganSum / currentAssignments;

//Console.WriteLine("Student\t\tGrade\n");
//Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
//Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
//Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
//Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

//Console.WriteLine("Press the Enter key to continue");
//Console.ReadLine();
