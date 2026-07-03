using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        double sumTotal = 0;
        int highest = int.MinValue;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (true)
        {
            Console.Write("Enter number: ");
            string numEntered = Console.ReadLine();
            int input = int.Parse(numEntered);
            if (input != 0)
            {
                numbers.Add(input);
                sumTotal += input;
                if (input > highest)
                {
                    highest = input;
                }
            }
            else
            {
                break;
            }



        }
        Console.WriteLine(numbers.Count);
        Console.WriteLine($"The sum is: {sumTotal}");
        Console.WriteLine($"The average is: {sumTotal / numbers.Count}");
        Console.WriteLine($"The largest number is: {highest}");

       
        numbers.Sort();


        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}