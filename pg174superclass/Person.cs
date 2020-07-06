using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg174superclass
{
    public class Person
    {
        //PROPERTIES
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //METHODS
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

    }
}
