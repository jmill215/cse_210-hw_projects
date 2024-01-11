using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your score? ");
        string userInput = Console.ReadLine();
        int score = int.Parse(userInput);
        string letter = ""; //noted difference in example solution, as I did not use the "" values intiially.

        //logic for letter grade, assigned by score
        if (score >= 90)
        {
           letter = "A";
        }
        else if (score >= 80)
        {
           letter = "B";
        }
        else if (score >= 70)
        {
           letter = "C";
        }
        else if (score >= 60)
        {
           letter = "D"; 
        }
        else
        {
           letter = "F"; 
        }

        //printing grade prior to pass/fail logic.
        Console.WriteLine($"\nGrade: {letter}");

        //logic for if student passed course or not, based on score
        if (score > 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the course. Please try again, you'll get it next time!");
        }

        /*Reminder of score distribution & syntax
 
        A >= 90
        B >= 80
        C >= 70
        D >= 60
        F < 60
    
        if (example statement) *same applies to else if or else
        {
            Console.Writeline, or equivalent statement;
        }
        */
    }
}