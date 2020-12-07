using System;
using System.Collections.Generic;
using PingPong.Logic;

namespace PingPong
{
  public class Program
  {
    public static int PingPongLoop(int userInput)
    {
      for (int i = 1; i <= userInput; i++) // initialize for loop
      {
        if (i % 3 == 0 && i % 5 == 0) // first if-statement: is the number divisible by 3 and 5 with a remainder of 0?
        {
          Console.WriteLine("ping-pong");
          continue; // skips over that number if it will be replaced by ping-pong
        }
        if (i % 3 == 0) 
        {
          Console.WriteLine("ping");
          continue;
        }
        if (i % 5 == 0)
        {
          Console.WriteLine("pong");
          continue;
        }
        else
        {
          Console.WriteLine(i); // the next number in the loop that doesn't meet the above conditions will log to the console
        }
      }
      return userInput; // avoids error "not all code paths return a value", and returns an int as stated in the method name
    }
    public static void Main()
    {
      Console.WriteLine("Enter a number: ");
      string strUserInput = Console.ReadLine();
      int userInput = int.Parse(strUserInput);
      PingPongLoop(userInput);
    }
  }
}

// get user input, number ranging from 1 to whatever
// use a for loop to output the range of numbers from 1 to the user's inputted number
// if the number outputted is divisible by 3, replace with ping
// if the number to be outputted is divisible by 5, replace with pong
// if the number to be outputted is divisible by 3 and 5, replace with "ping-pong"
// if (number % 3 == 0){ output "ping" } continue;
// if (number % 5 == 0){ output "pong" } continue;
// if (number % 3 == 0 && number % 5 == 0) { output "ping-pong"} continue;