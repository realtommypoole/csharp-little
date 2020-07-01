using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageShippingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter package weight");
            int pWeight = Convert.ToInt32(Console.ReadLine()); 
            
            if (pWeight > 50)
            {
                Console.WriteLine("Package is too heavy to ship. Try a different package.");
                Console.ReadLine();
            }

            Console.WriteLine("Enter package width");
            int pWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter package height");
            int pHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter package length");
            int pLength = Convert.ToInt32(Console.ReadLine());

            if ((pWidth + pHeight + pLength) > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express");
                Console.ReadLine(); 
            }
            else
            {
                double quote = pWidth * pHeight * pLength * pWeight/100.00;
                Console.WriteLine("The total cost to ship is: $" + quote);
                Console.ReadLine();
            }
        }
    }
}
