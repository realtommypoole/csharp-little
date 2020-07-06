using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg169otuputparameters
{
    public class MyClass
    {


        //-----PROPERTIES-----------//
        public int Num = 3;
        

        //-------------METHODS------------------//
        public int MyMethod (int Num)
        {
            return Num / 2;
        }

        public int MyMethod(int Num, int a)
        {
            return Num / 2 + a;
        }


        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
        }



    }
}
