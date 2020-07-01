using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;

            string[] stringArray1 = new string[] { "jeb", "jim", "jan"};

            List<string> intList = new List<string>();
            intList.Add("four");
            intList.Add("ten");

            


            Console.WriteLine("Pick a number: 0 or 1");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1 || a == 2)
            {
                Console.WriteLine(stringArray1[a]);
            }
            else
            {
                Console.WriteLine("You must pick a 1 or 0!");
                Console.ReadLine();
            }

            Console.WriteLine("Pick a number 0 or 1");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b == 1 || b == 2)
            {
                Console.WriteLine(numArray[b]);
            }
            else
            {
                Console.WriteLine("You must pick a 1 or 0!");
                Console.ReadLine();
            }

            Console.WriteLine("Pick a number: 0 or 1");
            int c = Convert.ToInt32(Console.ReadLine());

            if (c == 1 || c == 2)
            {
                Console.WriteLine(intList[c]);
            }
            else
            {
                Console.WriteLine("You must pick a 1 or 0!");
                Console.ReadLine();
            }

            Console.WriteLine("You did great!");
            Console.ReadLine();

        }
    }
}
