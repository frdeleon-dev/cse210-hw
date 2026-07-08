using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage (0-100): ");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);
        string letterGrade = "";
        string gradeSign = "";

        // Calculate the last digit of the grade to determine the sign
        int lastDigit = gradePercentage % 10;

        // Determine the letter grade based on the percentage
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Determine the sign based on the last digit of the grade
        if (gradePercentage == 100)
        {
            gradeSign = "";
        }
        else if (lastDigit >= 7 && letterGrade != "A" && letterGrade != "F")
        {
            gradeSign = "+";
        }
        else if (lastDigit <= 2 && letterGrade != "F")
        {
            gradeSign = "-";
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}{gradeSign}");

        if (letterGrade == "F" || letterGrade == "D")
        {
            Console.WriteLine("Don't give up! Keep trying and you will do better next time.");
        }
        else
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
    }
}