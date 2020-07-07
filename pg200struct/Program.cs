using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg200struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number MyAmount = new Number();
            MyAmount.Amount = 45.43;

            Console.WriteLine(MyAmount.Amount);
            Console.ReadLine();

        }
    }
}
