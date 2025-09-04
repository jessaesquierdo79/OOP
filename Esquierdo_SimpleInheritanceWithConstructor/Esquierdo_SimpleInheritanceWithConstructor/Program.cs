using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquierdo_SimpleInheritanceWithConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regular regular = new Regular("Jessa Mae Esquierdo", "BSIT", "IT306");
            regular.SectionEnrolled(); // Display Basic Info

            Irregular irregular = new Irregular("Shanly Anne Gonzales", "TM103", "24");
            irregular.EnrolledSemUnits(); // Diplay Basic Info

            Console.ReadKey();
        }
    }
}
