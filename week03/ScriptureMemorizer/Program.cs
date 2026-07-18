// Showing Creativity and Exceeding Requirements:
// I exceeds the requirements only selecting visible words
// when hiding words. Once a word has been hidden, it will not be selected again.
using System;

class Program
{
    static void Main(string[] args)
    {
        
        string text1 = "Trust in the LORD with all your heart, and do not lean on your own understanding. In all your ways acknowledge Him, and He will make straight your paths.";

        
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture1 = new Scripture(reference1, text1);

        bool keepPlaying = true;

        while (keepPlaying == true && !scripture1.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture1.GetDisplayText());

            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                keepPlaying = false;
            }
            else
            {
                scripture1.HideRandomWords(3);
            }
        }

        Console.Clear();

        Console.WriteLine(scripture1.GetDisplayText());

    }
}