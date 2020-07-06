using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg182interface
{
    interface IQuittable
    {

        void Quit(Employee employee)
        {
            Console.WriteLine("My name is" + employee + "I quit.");
        }
    }
}
