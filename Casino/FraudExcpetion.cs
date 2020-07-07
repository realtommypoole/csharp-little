using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino1
{
    public class FraudExcpetion : Exception
    {
        //CONSTRUCTORS, using same implementation as Excpetion
        public FraudExcpetion()
            : base() { }
        public FraudExcpetion(string message)
            : base(message) { }

    }
}
