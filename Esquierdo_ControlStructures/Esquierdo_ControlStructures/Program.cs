using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquierdo_ControlStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
        START:   // Label for repeating

            Console.Clear();
            Console.WriteLine("This program will determine what type of number and display its range.\n");

            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            int number;

            // INVALID INPUT
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Please re-try to enter a numeric value.\n");
            }
            else
            {
                // ODD NUMBER
                if (number % 2 != 0)
                {
                    Console.WriteLine("Sorry, I cannot provide the range of numbers based from the number you entered.\n");
                }
                else
                {
                    // EVEN NUMBER
                    Console.WriteLine($"{number} is an even number\n");
                    Console.WriteLine("This is the range of numbers based from the number you entered.");

                    for (int i = number; i >= 2; i -= 2)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("\n");
                }
            }

            // ASK AGAIN
            Console.Write("Do you want to try again (y/n)? ");
            string ans = Console.ReadLine().ToLower(); // NOT case-sensitive

            if (ans == "y")
            {
                goto START;   // Repeat
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Thank you for using this program.");
            }

            Console.ReadKey();
        }
    }
}