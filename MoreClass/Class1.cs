using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClass
{
    public class Class1
    {
        
        public int MyMe(int Num)
        {
            return Num + 3;
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
