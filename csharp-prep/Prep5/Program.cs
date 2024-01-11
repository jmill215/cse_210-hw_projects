using System;

class Program
{
    static void Main(string[] args)
    {
        //Noted difference in code -- make sure to space code out when doing it in the future!
        // Functions call
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numSquare = SquareNumber(userNumber);
        DisplayResult(userName, numSquare);

        // Display Welcome
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // Prompt user name (edit: changed name variable after reading the solution code, as it was cleaner)
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // Prompt User Number
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        // Square number
        static int SquareNumber(int userNumber)
        {
            double squaredNum = Math.Pow(userNumber, 2);
            return (int)squaredNum;
        }

        static void DisplayResult(string userName, int squaredNum)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNum}");
        }
    }
}