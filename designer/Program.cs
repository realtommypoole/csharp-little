using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace designer
{
    class Program
    {

        static void MyMethod()
        {
            Console.WriteLine("I just got executed");
        }

        static void AnotherMethod(string fname)
        {
            Console.WriteLine(fname + "Refsnes");
        }

        static int AnMethod(int x)
        {
            return 5 + x;
        }

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {

            ////Type your username and press enter
            //Console.WriteLine("Enter username:");

            ////Create a string variable and get user input from the keyboard and stor it in the variable
            //string userName = Console.ReadLine();

            ////Print the value of the variable (userName), which will display the input value
            //Console.WriteLine("Username is: " + userName);

            //Console.WriteLine("Enter age:");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(userName + " is "+ age + " years old.");

            //int x = 9;
            //Console.WriteLine(x ^ 2);

            //MyMethod();
            //MyMethod();

            AnotherMethod("Liam");
            AnotherMethod("Jenny");

            Console.WriteLine(AnMethod(3));

            Console.WriteLine(PlusMethod(3, 4));
            Console.WriteLine(PlusMethod(4.5, .34));


            Console.ReadLine();
                }
    }
}
