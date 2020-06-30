using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hi there, enter a one or two digit number and hit enter.");
            string answer = Console.ReadLine();
            int b = Convert.ToInt32(answer);
            //int c = b;
            int d = b*50;
            Console.WriteLine(d);

            Console.WriteLine("Enter another one or two digit number and hit enter.");
            string ansTwo = Console.ReadLine();
            int e = Convert.ToInt32(ansTwo);
            int f = e + 25;
            Console.WriteLine(f);

            Console.WriteLine("Enter a two digit number and hit enter.");
            string ansThree = Console.ReadLine();
            int g = Convert.ToInt32(ansThree);
            double h = g / 12.5;
            Console.WriteLine(h);

            Console.WriteLine("Enter another one or two digit number and hit enter.");
            string ansFour = Console.ReadLine();
            int i = Convert.ToInt32(ansFour);
            bool j = i > 50;
            Console.WriteLine(j);

            Console.WriteLine("Enter another one or two digit number and hit enter.");
            string ansFive = Console.ReadLine();
            int k = Convert.ToInt32(ansFour);
            int l = k % 7;
            Console.WriteLine(l);
            Console.ReadLine();

            Console.WriteLine("Hit enter to end this awesome game.");
            Console.ReadLine();




        }
    }
}
