using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg169otuputparameters
{
    public class staticexample
    {
        //Static Fields
        public static string CollegeName;
        public static string Address; 

        //Static Constructor
        public string MyCollege()
        {
            CollegeName = "Sam Yuk College Hong Kong";
            Address = "1111 Clear Water Bay Road";
            return CollegeName + Address;
        }

    }
}
