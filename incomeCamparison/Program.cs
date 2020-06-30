using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incomeCamparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program.");
            Console.WriteLine("Enter the details for Person 1:");
            Console.WriteLine("Hourly Rate: ");
            string p1Rate = Console.ReadLine();
            Console.WriteLine("Hours Worked: ");
            string p1Hours = Console.ReadLine();

            Console.WriteLine("Enter the details for Person 2:");
            Console.WriteLine("Hourly Rate: ");
            string p2Rate = Console.ReadLine();
            Console.WriteLine("Hours Worked: ");
            string p2Hours = Console.ReadLine();

            int a = Convert.ToInt32(p1Rate);
            int b = Convert.ToInt32(p1Hours);
            int c = a * b * 52;

            int d = Convert.ToInt32(p2Rate);
            int e = Convert.ToInt32(p2Hours);
            int f = d * e * 52;
            
            bool g = c > f;

            Console.WriteLine("Annual salary of Person 1:" + c);

            Console.WriteLine("Annual Salary of Person 2:" + f);

            Console.WriteLine("Does Person 1 make more than Person 2? " + g);
            Console.ReadLine();
        }
    }
}
