// Creativity: The program keeps track of how many mindfulness activities the user complete.
using System;

class Program
{
    static void Main(string[] args)
    {

        string userChoice = "";
        int completedActivities = 0;
        while (userChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Breathing activity");
            Console.WriteLine("  2. Reflecting activity");
            Console.WriteLine("  3. Listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    completedActivities++;
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    completedActivities++;
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    completedActivities++;
                    break;
                case "4":
                    Console.WriteLine($"\nYou completed {completedActivities} mindfulness activities this session.");
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
