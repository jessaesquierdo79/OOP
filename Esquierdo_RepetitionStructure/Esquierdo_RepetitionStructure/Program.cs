using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquierdo_RepetitionStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Jessa Mae Esquierdo
            //Section:IT306
            //PROBLEM:  Use a for loop structure to print 10 numbers, and print also the sum of all the numbers.

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Number Printer and Sum Calculator");

            int sum = 0;

            // Loop to print numbers 1 to 10 and calculate their sum
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nThe first 10 natural numbers are:");

            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("\n \t Number:\t " + i);
                sum += i;
            }

            // Display the sum
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nThe sum of these numbers is: {sum}");

            // Keep console window open until user presses a key
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
