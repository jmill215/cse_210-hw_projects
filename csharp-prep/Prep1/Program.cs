using System;

class Program
{
    static void Main(string[] args)
    {
        //start of project (beginning with fname)
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        //last name (lname)
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        //final logic and end of program
        Console.WriteLine($"\nYour name is {lname}, {fname} {lname}.");
    }
}