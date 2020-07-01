using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string uAge = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI?");
            string uDui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string uSpeed = Console.ReadLine();


            bool d = Convert.ToBoolean(uDui);
            int e = Convert.ToInt32(uAge);
            int f = Convert.ToInt32(uSpeed);

            bool g = (d == false && e > 15 && f <= 3);


            Console.WriteLine("Qualified? " + g);
            Console.ReadLine();

        }
    }
}
