using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MoreClass
{
    class Program
    {
        static void Main(string[] args)
        {

            ////METHOD ONE
            //Class1 numOne = new Class1();
            //int x = 5;

            ////METHOD TWO
            //Class1 numOne = new Class1();
            //double x = 4.3;

            //METHOD THREE
            Class1 numOne = new Class1();
            string x = "3";

            Console.WriteLine(numOne.MyMe(x));
            Console.ReadLine();
        }
    }
}
