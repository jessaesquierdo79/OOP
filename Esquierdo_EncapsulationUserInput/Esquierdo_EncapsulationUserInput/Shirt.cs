using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquierdo_EncapsulationUserInput
{
    internal class Shirt
    {
        // Auto-implemented properties (short-hand encapsulation)
        public string Brand { get; set; }
        public string Color { get; set; }

        // Method to display details
        public void DisplayDetails()
        {
            Console.WriteLine("\nShirt Information:");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
        }
    }
}

    

