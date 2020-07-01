using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Jesse";
            string middleName = "Jon";
            string lastName = "James";

            string fullName = firstName + middleName + lastName;
            Console.WriteLine(fullName);

            string up = fullName.ToUpper();
            Console.WriteLine(up);

            StringBuilder sb = new StringBuilder();

            sb.Append("Once upon a time.");
            sb.Append("There was a bear.");
            sb.Append("Hungry and desperate.");
            sb.Append("Just outside your room.");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
