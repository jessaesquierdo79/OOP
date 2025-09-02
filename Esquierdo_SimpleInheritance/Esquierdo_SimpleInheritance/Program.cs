using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquierdo_SimpleInheritance
{
    internal class Program
    {
        // Name: Jessa Mae Esquierdo
        // Section: IT306
        // Exercise Title:Use these classes:  Student class (Base class); RegularStudent class (Derived class); IrregularStudent class (Derived class)

        static void Main(string[] args)
        {
            //Create an instance of the Regular student
            Regular myRegular = new Regular
            {
                Name = "Jessa Mae Esquierdo",
                Program = "BSIT",
                Section = "IT306"
            };
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\t*****Regular Student****\n");
            myRegular.StudentBasicInfo();
            myRegular.SectionEnrolled();

            //Create an instance of the Irregular class
            Irregular myIrregular = new Irregular
            {
                Name = " Shanly Anne Gonzales",
                Program = "BSTM",
                UnitsEnrolled = "Irregular"
            };
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\t****Irregular Student****\n");
            myIrregular.StudentBasicInfo();
            myIrregular.EnrolledSemUnits();

            //Wait for user input before closing
            Console.ReadKey();
        }
    }
}
