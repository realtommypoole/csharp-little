using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg166VoidInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidClass varOne = new VoidClass();
            varOne.TheseNumbers(3, 7);
            varOne.TheseNumbers(nOne: 7, nTwo: 5);
            Console.ReadLine();
        }
    }
}
