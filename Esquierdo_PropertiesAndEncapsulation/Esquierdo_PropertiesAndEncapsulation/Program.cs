using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquierdo_PropertiesAndEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create object of shirt
            Shirt shirt1 = new Shirt();
            //Set values using propeties
            shirt1.Brand = "UNIQLO";
            shirt1.Color = "Plane White";

            //Desplay Details
            shirt1.DisplayDetails();

            Console.ReadLine();

        }
    }
}
        
    

