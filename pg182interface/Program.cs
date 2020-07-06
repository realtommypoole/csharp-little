using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg182interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();

            
            IQuittable em = new Employee();
            em.Quit(employee);
            Console.ReadLine();

        }
    }
}
