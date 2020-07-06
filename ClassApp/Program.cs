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
            int userNum = Convert.ToInt32(Console.ReadLine());

            MyNumber numOne = new MyNumber();
            numOne.Num = userNum;

            numOne.MyAdder();
            numOne.MySubber();
            numOne.MyMulti();
            Console.ReadLine();

        }
    }
}
