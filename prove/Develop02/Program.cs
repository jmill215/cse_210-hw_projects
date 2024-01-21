using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        bool quitEntered = false;

        Journal theJournal = new Journal();
        PromptGenerator randPrompt = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        while (quitEntered != true)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            int isNumeric = int.Parse(userInput);

            if (isNumeric > 5 || isNumeric < 0)
            {
                Console.WriteLine("Invalid Input detected, please try again");
            } 
            else 
            {
                if (isNumeric == 1)
                {
                   Entry journalEntry = new Entry();
                   journalEntry._promptText = randPrompt.GetRandomPrompt();
                   Console.WriteLine(journalEntry._promptText);
                   Console.Write("");
                   journalEntry._entryText = Console.ReadLine();
                   
                   string currentDay = DateTime.Now.ToString("MMMM dd, yyyy");
                   journalEntry._date = currentDay;

                   theJournal.AddEntry(journalEntry);
                }
                else if(isNumeric == 2)
                {
                   theJournal.DisplayAll();
                }
                else if(isNumeric == 3)
                {
                   theJournal.LoadFromFile("journalfile.txt");
                }
                else if(isNumeric == 4)
                {
                   theJournal.SaveToFile("journalfile.txt");
                }
                else if(isNumeric == 5)
                {
                   Console.WriteLine("Thank you for using the Journal App! Have a great day.");
                   quitEntered = true;
                }
            } 
            
        }
    }
}