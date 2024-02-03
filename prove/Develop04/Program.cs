using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool quitEntered = false;

        while (quitEntered != true)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a Choice from the menu: ");
            int userChoice = int.Parse(Console.ReadLine());

            //For review, make new activity, then use Run()
            if (userChoice == 1)
            {
               BreathingActivity breathingAct = new BreathingActivity();
               breathingAct.run();
            } else if (userChoice == 2)
            {
              ReflectingActivity newReflect = new ReflectingActivity(); 
              newReflect.Run(); 
            } else if (userChoice == 3)
            {
                ListingActivity listAct = new ListingActivity();
                listAct.Run(); 
            } else if (userChoice == 4)
            {
                quitEntered = true;
            } else {
                Console.WriteLine("Invalid input detected. Please try again!");
            }
        }
    }
}