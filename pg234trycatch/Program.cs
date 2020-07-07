using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg234trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age.");
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x > 1 && x < 140)
                {
                    Console.WriteLine("You entered {0}. You were born in the year : " + (DateTime.Now.Year - x), x);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You must enter a whole number between 1-140.");
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please contact your System Administrator.");
                Console.ReadLine();
                return;
            }
        }
    }
}
