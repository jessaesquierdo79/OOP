using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esquierdo_CaO
{
    internal class Program
    {
        //Name:Jessa Mae Esquierdo
        //Section: IT306
        //TASK : Create a class
        static void Main(string[] args)
        {
            {
                Person personal = new Person();  //Instantiation of an object 

                //Instantiation of fields
                personal.name = "Jessa MAe Esquierdo";
                personal.age = 19;
                personal.gender = "Female";

                //Call The Method 
                personal.Greet();

                Console.ReadKey();

            }
        }
    }
}
    

