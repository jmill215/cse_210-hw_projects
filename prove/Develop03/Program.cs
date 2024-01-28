using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
       Reference book1 = new Reference("Jacob", 2, 3, 4); 

       Scripture toMemorize1 = new Scripture(book1, "And ye yourselves know that I have hitherto been diligent in the office of my calling; but I this day am weighed down with much more desire and anxiety for the welfare of your souls than I have hitherto been. For behold, as yet, ye have been obedient unto the word of the Lord, which I have given unto you.");

       
        string input = " ";

        while (input != "quit" & toMemorize1.IsCompletelyHidden() != true)
        {
            Console.Clear();

            Console.WriteLine($"{toMemorize1.GetDisplayText()}\n");
            Console.WriteLine("Please enter to continue or type 'quit to finish");
            input = Console.ReadLine();

            toMemorize1.HideRandomWords(2);

            if (toMemorize1.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine($"{toMemorize1.GetDisplayText()}\n");
            }
        }

       
    }
}