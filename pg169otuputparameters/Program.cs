using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg169otuputparameters
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass n = new MyClass();

            Console.WriteLine("Enter a number between 50-100");
            int Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n.MyMethod(Num));
            Console.ReadLine();

            int a, b;
            n.getValues(out a, out b);

            Console.WriteLine("After method call, value of a: {0}", a);
            Console.WriteLine("After method call, value of b: {0}", b);
            Console.ReadLine();

            Console.WriteLine(n.MyMethod(Num, a));
            Console.ReadLine();

        }

    }
}
