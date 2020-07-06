using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    public class MyNumber
    {
        public void MyAdder()
        {
            Console.WriteLine(Num + 3);
        }

        public void MySubber()
        { 
            Console.WriteLine(Num - 3);
        }
        
        public void MyMulti()
        {
            Console.WriteLine(Num * 3);
        }

        public int Num { get; set; }
    }
}
