using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Which number do you want to do math on? Type: (2, 4, or 6):");
            int u = Convert.ToInt32(Console.ReadLine());
            var myNumber = new MyNumber();

            MyNumber z = new MyNumber();

            int s = z.MyAdder(u);
            int a= z.MySubber(s);
            int d=z.MyMulti(a);
            Console.WriteLine(d);
            Console.ReadLine();

        }
    }
}
