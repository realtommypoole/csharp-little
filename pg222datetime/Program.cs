using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg222datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Put in a number of hours, whole number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(now.AddHours(x));
            Console.ReadLine();

        }
    }
}
