using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triesCount = 5;
            int userInput;
            Random rand = new Random();
            int number = rand.Next(0, 101);
            int hint = rand.Next(0, 10);

            Console.WriteLine($"There is a number from {number - hint} to {number + hint}. Try to guess it (you have {triesCount} attempts).");

            while (triesCount-- > 0)
            {
                Console.Write("Type a number:");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (number == userInput)
                {
                    Console.WriteLine("You have guessed!");
                    Console.WriteLine($"It was {number}");
                    Console.ReadKey();
                    break;
                }
                
                else
                {
                    Console.WriteLine("Incorrect! Try again.");
                }
            }
            
            if (triesCount < 0) 
            {
                Console.WriteLine("You lost! Guessed number was " + number + ".");
                Console.ReadKey();
            }
          
        }
    }
}
