using System;

class Program
{
    static void Main(string[] args)
    {
        
        //part 1 & 2
        //Console.Write("What is the magic number? ");
        //string magicNum = Console.Readline();
        //int magicNumInt = int.Parse(magicNum);

        //part 3
        bool numCorrect = false;

        Random magicNum = new Random();
        int magicNumInt = magicNum.Next(1, 100);

        while (numCorrect == false)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            int userGuessInt = int.Parse(userGuess);

        //logic
            if (userGuessInt > magicNumInt)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuessInt < magicNumInt)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                numCorrect = true;
                Console.WriteLine("You guessed it!");
            }
        }
    }
}