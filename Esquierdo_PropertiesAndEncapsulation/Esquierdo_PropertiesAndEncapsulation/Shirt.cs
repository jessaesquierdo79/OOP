using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquierdo_PropertiesAndEncapsulation
{
    internal class Shirt
    {
        //Declare the properties of the shirt class
        private string brand;
        private string color;

        //Set the Properties of the shirt class
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //Method to Dispaly Details
        public void DisplayDetails()

        {
            Console.WriteLine("Bag Information:");
            Console.WriteLine("Brand:" + brand);
            Console.WriteLine("Color:" + color);
        }
    }
}

    

