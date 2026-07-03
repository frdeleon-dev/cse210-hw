using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        /* Instantiate the Random object outside the loop to ensure it is initialized only once.
        This prevents the random number generator from being reset with the same system clock seed
        during rapid successive games, ensuring truly random numbers each match.*/
        
        int counter;
        int magicNumber;
        string guessInput;
        int guess;
        string keepPlaying = "yes";
        /* Declare all local variables at the beginning of the Main method 
        to maintain better code organization, clarity, and readability.*/



        while (keepPlaying == "yes" || keepPlaying == "y")
        {
            counter = 1;
            /* Initialize the counter to 1 because the user makes their first guess 
            outside and prior to entering the feedback loop.*/
            
            magicNumber = randomNumber.Next(1, 101);
            /* REMINDER: This assignment doesn't need to happen immediately after creating the Random object.
            It can be placed anywhere before the game loop starts, as long as 'magicNumber' has a value 
            before the user makes their first guess.*/


            Console.Write("What is your guess? ");
            guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            /*REMINDER: 'int.Parse' converts the text (string) entered by the user into an integer (int).
            This is required because 'Console.ReadLine()' always reads input as text, 
            and we need a number to perform mathematical comparisons (<, >, !=).*/

            while (guess != magicNumber)
            {
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                Console.Write("What is your guess? ");
                guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);
                counter++;
            }
            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {counter} guesses.");
            }
            Console.Write("Do you want to play again? (yes/no) ");
            keepPlaying = Console.ReadLine().ToLower();
            /* '.ToLower()' converts any uppercase characters in the string to lowercase.
            This standardizes the text input so comparisons are case-insensitive.*/
        }
    }
}