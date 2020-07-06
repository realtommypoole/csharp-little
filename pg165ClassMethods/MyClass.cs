using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg165ClassMethods
{
    public class MyClass
    {
       
        public int AddNumber(int hours, int speed = 2)
        {
            return hours/speed;
        }

        public double MyMe(double Num)
        {
            return Convert.ToInt32(Num + 10.1);
        }

        public int MyMe(string Num)
        {
            int x = Convert.ToInt32(Num);
            return x + 23;
        }

        public int Num { get; set; }

        
    }
}
