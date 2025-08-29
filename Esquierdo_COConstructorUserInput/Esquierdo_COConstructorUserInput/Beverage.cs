using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquierdo_COConstructorUserInput
{
    internal class Beverage
    {
        //Attributes
        public string brand;
        public string size;
        public string flavor;

        public Beverage(string aBrand, string aSize, string aFlavor)  //Parameterized Constructor
        {
            brand = aBrand;
            size = aSize;
            flavor = aFlavor;
        }

        //Method to Dsiplay the Beverage Details
        public void DisplayBeverageDetails()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-------- Here are the Beverage Details --------");
            Console.WriteLine("Beverage Brand: " + brand);
            Console.WriteLine("Beverage Size: " + size);
            Console.WriteLine("Beverage Flavor: " + flavor);

        }

    }
}
