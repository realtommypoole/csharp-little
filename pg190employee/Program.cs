using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace pg190employee
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> emp3 = new Employee<string>();
            emp3.Things = new List<string>() { "fish", "forrest", "fire" };

            foreach (string employee in emp3.Things)
            {
                Console.WriteLine(employee);

            }

            Employee<int> emp4 = new Employee<int>();
            emp4.Things = new List<int>() { 6, 7, 9 };

            foreach (int employee in emp4.Things)
            {
                Console.WriteLine(employee);

            }



            Console.ReadLine();

        } 
    }
}
