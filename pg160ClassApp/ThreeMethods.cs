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
        public int MyAdder(int x)
        {
            return (x + 3);
        }

        public int MySubber(int x)
        { 
            return(x - 3);
        }
        
        public int MyMulti(int x)
        {
            return(x * 3);
        }

    }
}
