// Creativity: I decide validate the user's journal entry, the program does not allow empty or whitespace-only

using System;
using System.IO;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        
        Journal myJournal = new Journal();
        while (true)
        {
            
        

        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like todo? ");
        string customerChoice = Console.ReadLine();

            if (customerChoice == "1")
            {
                
                PromptGenerator promptGen = new PromptGenerator(Information, imfo);
                
                
                string prompt = promptGen.GetRandomPrompt();
                
                Console.WriteLine(prompt);
                Console.Write(">>");
                string response = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Your journal entry cannot be empty.");
                }
                else
                {
                    
        
                string date = DateTime.Now.ToShortDateString();

                
                Entry newJournalEntry = new Entry();
                newJournalEntry._date = date;
                newJournalEntry._promptText = prompt;
                newJournalEntry._entryText = response;

                
                    myJournal.AddEntry(newJournalEntry);
                    Console.WriteLine("Journal entry added successfully!");
                }

            }
            else if (customerChoice == "2")
            {
                myJournal.Display();
            }

            else if (customerChoice == "3")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();

                myJournal.LoadFromFile(fileName);
            }

            else if (customerChoice == "4")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();

                myJournal.SaveToFile(fileName);
            }

            else if (customerChoice == "5")
            {
                break;
            }

            else
            {
                Console.WriteLine($"{customerChoice} is not a valid choice, please try again");
            }

        }

    }
}