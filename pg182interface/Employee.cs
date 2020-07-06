using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg182interface
{
    class Employee : Person
    {
        //PROPERTIES
        public int Id { get; set; }

        //public void Quit(Employee employee)
        //{
        //    Console.WriteLine("I quit.");
        //}

        // this is first one '=='
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1.Id == emp2.Id)
                return true;
            else
                return false;
        }

        // this is second one '!='
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (emp1.Id != emp2.Id)
                return true;
            else
                return false;
        }

    }
}
