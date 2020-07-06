using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg165ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClass Number = new MyClass();

            Console.WriteLine("Enter a number between 1-10:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number between 1-10, or leave blank to use the default value:");
            string y = Console.ReadLine();

            if (string.IsNullOrEmpty(y))
            { 
                int z = Number.AddNumber(x);
                Console.WriteLine("Your first number divided by your second number is: " + z);

            }
            else
            {
                int c = Convert.ToInt32(y);
                int z = Number.AddNumber(x, c);
                Console.WriteLine("Your first number divided by your second number is: " + z);

            }
            Console.ReadLine();

        }
    }
}
