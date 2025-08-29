using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquierdo_COConstructorUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Main:
            Console.Clear();
            //Ask the user to input
            Console.WriteLine("This program will ask about your favorite beverage. \n\n");
            Console.Write("Enter brand name (Coke/Sprite/Royal): \t");
            string aBrand = Console.ReadLine();

            Console.Write("Enter size (8oz/12oz):      \t");
            string aSize = Console.ReadLine();

            Console.Write("Enter flavor (Ex. Coke: Regular or Zero):   \t");
            string aFlavor = Console.ReadLine();

            //Instantiate a class object
            Beverage beverage1 = new Beverage(aBrand, aSize, aFlavor);

            //Call the method to display
            beverage1.DisplayBeverageDetails();

            //Input another book details
            Console.Write("\nDo you want to try again (y/n)? ");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'y')
            {
                goto Main;
            }
            else if (ans == 'n')
            {
                return;
            }
        }
    }
}

        
    

