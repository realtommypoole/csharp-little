using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg182interface
{
    class Employee : Person, IQuittable
    {
        //PROPERTIES
        public int Id { get; set; }

        public void Quit(Employee employee)
        {
            Console.WriteLine("I quit.");
        }
    }
}
