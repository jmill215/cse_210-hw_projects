using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Enter a list of numbers, type 0 when finished.");
      
      //Note: use negative numbers for loop condition, as booleans can be tempermental in terms of program exit
      List<int> numbers = new List<int>();
      
      int number = -1;

      while (number != 0)
      {
        Console.Write("Enter Number: ");
        string userInput = Console.ReadLine();
        number = int.Parse(userInput);
        
        if (number != 0)
        {
          numbers.Add(number);
        }
      }

      //iterating through list items for sum/average/largest, instead of using the built in methods
      
      //sum
      int sum = 0;
      foreach (int num in numbers) //avoiding similarity to variable in use during loop
      {
        sum += num;
      }
      Console.WriteLine($"The sum is: {sum}");

      //average (using float and previous sum, instead of using the built in function for average)
      float avg = ((float)sum) / numbers.Count; //note to self: remember to use parentheses around float if not defining a variable
      Console.WriteLine($"The average is: {avg}");

      //largest
      int largest = numbers[0];
      foreach (int num in numbers) //avoiding similarity to variable in use during loop
      {
        if (num > largest)
        {
          largest = num;
        }
      }
      Console.WriteLine($"The largest number is: {largest}");
    }
}