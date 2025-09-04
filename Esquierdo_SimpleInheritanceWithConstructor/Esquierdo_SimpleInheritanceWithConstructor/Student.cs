using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquierdo_SimpleInheritanceWithConstructor
{
    class Student  // base class
    {
        // fields
        public string name;
        public string program;

        // conctructor
        public Student(string StudentName, string StudentProgram)
        {
            name = StudentName;
            program = StudentProgram;
        }

        public void BasicInfo()
        {
            Console.WriteLine($"\n  Name: {name}  \n  Program: {program}");
        }
         
    }

    class Regular : Student  // derived class
    {
        //field
        public string Section;

        //constructor
        public Regular(string StudentName, string StudentProgram, string StudentSection) : base(StudentName, StudentProgram)
        {
            Section = StudentSection;
        }
        //Method to  Student Info
        public void SectionEnrolled()
        {
            BasicInfo();
            Console.WriteLine($"  Section: {Section}");
        }
    }  
    class Irregular : Student // Derived Class
    {
        public string UnitsEnrolled;

        // constractor
        public Irregular(string StudentName,string StudentProgram,string StudentUnitsEnrolled) : base(StudentName, StudentProgram)
        {
            UnitsEnrolled = StudentUnitsEnrolled;
        }
        //Method to Display student Info
        public void EnrolledSemUnits()
        {
            BasicInfo();
            Console.WriteLine($"  UnitsEnrolled: {UnitsEnrolled}");

            Console.ReadKey();
        }
    }
}

