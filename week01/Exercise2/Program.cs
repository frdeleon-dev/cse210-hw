using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage (0-100): ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);

        string letter = "";
        string sign = "";

        if(grade >= 90)
        {
           letter = "A";      
           if (grade == 100)
            {
                sign = "";
            }
           else if (grade % 10 <= 2)
            {
                sign = "-";
            }      
        }
        else if(grade >= 80)
        {
            letter = "B";
            if (grade % 10 >= 7)
            {
                sign = "+";
            }
            else if (grade % 10 <= 2)
            {
                sign = "-";
            }
        }
        else if(grade >= 70)
        {
            letter = "C";
            if (grade % 10 >= 7)
            {
                sign = "+";
            }
            else if (grade % 10 <= 2)
            {
                sign = "-";
            }
        }
        else if(grade >= 60)
        {
            letter = "D";
            if (grade % 10 >= 7)
            {
                sign = "+";
            }
            else if (grade % 10 <= 2)
            {
                sign = "-";
            }
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (letter == "F" || letter == "D")
        {
            Console.WriteLine("Don't give up! Keep trying and you will do better next time.");
        }
        else
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
    }
}