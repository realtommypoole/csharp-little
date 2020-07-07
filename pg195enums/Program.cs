using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace pg195enums
{
    class Program
    {
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a day of the week.");
                string UserDay = Console.ReadLine();

                foreach (int i in Enum.GetValues(typeof(Days)))
                {                        
                    if ((Enum.GetName(typeof(Days), i)) == UserDay)
                    {
                        Console.WriteLine("Thanks for picking a day of the week!");
                    }
                } 
            }
            catch
            {
                Console.WriteLine("Please pick a valid day of the week.");
            }

            Console.ReadLine();

            }
    }
}
