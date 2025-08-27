using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquierdo_EncapsulationUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user for input
            Console.Write("Enter Shirt Brand: ");
            string brandInput = Console.ReadLine();

            Console.Write("Enter Shirt Color: ");
            string colorInput = Console.ReadLine();

            // Instantiate Shirt object with user input
            Shirt shirt1 = new Shirt
            {
                Brand = brandInput,
                Color = colorInput
            };

            // Display Shirt details
            shirt1.DisplayDetails();

            Console.ReadLine();
        }
    }
}

        
    

