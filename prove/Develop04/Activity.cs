using System;
using System.Threading;

public class Activity
{
    protected string _name;

    protected string _description;

    protected int _duration;

 
    public Activity()
    {
        //define class variables for later use in derived

        _name = "";
        _description = "";
        _duration = 0;
    }
    
    public void DisplayStartingMessage() 
    {
        Console.Clear(); //clearing console of previous display
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description + "\n");
        Console.Write("How long, in seconds, would you like for your session? (Please enter increments of 10): ");
        string durInput = Console.ReadLine();
        _duration = int.Parse(durInput);

        Console.Clear();
        Console.Write("Get Ready...");
        showSpinner(3);
        Thread.Sleep(500);
        Console.WriteLine();
    }

    // Animation and Timer
    public void DisplayEndingMessage() 
    {
        Console.WriteLine("Well Done!! \n");

        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        showSpinner(6);
        Thread.Sleep(500);
        Console.Clear();
    }

    public void showSpinner(int seconds)
    {
        //show spinner at the beginning of the program, and at end before returning to menu.
        
        List<string> spinner = new List<string> {"|", "/", "-", "\\"};
        
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime) 
        {
            foreach(string spin in spinner) {
                Console.CursorVisible = false;
                Console.Write(spin);
                Thread.Sleep(200);
                Console.Write("\b \b");
            }   
        }
        Console.CursorVisible = true;
        
    }

    public void showCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--) 
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}