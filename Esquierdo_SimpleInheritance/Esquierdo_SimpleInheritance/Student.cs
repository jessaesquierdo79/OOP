using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquierdo_SimpleInheritance
{
    internal class Student
    {
        //Properties for the Student Class
        public string Name { get; set; }
        public string Program { get; set; }

        //Method to Display Student Information
        public void StudentBasicInfo()
        {
            Console.WriteLine($"Name: {Name}, \nProgram: {Program}");
        }
    }

    class Regular : Student //Derived Class
    {
        //Additional property for the Regular class
        public string Section { get; set; }

        //Method to Display Regular Information
        public void SectionEnrolled()
        {
            Console.WriteLine($"Section: {Section}");
        }
    }
    class Irregular : Student //Another derived class
    {
        //Additional property for the Irregular Class
        public string UnitsEnrolled { get; set; }

        //Method to Display Irregular Information
        public void EnrolledSemUnits()
        {
            Console.WriteLine($"UnitsEnrolled: {UnitsEnrolled}");
        }
    }
}

