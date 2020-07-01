using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentTemperature = 70;
            int roomTemperature = 70;

            Console.WriteLine("Hi, what is your name!");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your favorite number?"); 
                int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "you have an awesome favorite number" : "you do not have an awesome favorite number";
            Console.WriteLine(result);
            Console.ReadLine();


            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature");

            }
            else if (currentTemperature < roomTemperature)
            {
                
            }
            else
            {
                Console.
            }

            string comparisonResult = currentTemperature == roomTemperature ? "It is room temp" : "It is not room temp";
            Console.WriteLine(comparisonResult);
            Console.ReadLine();

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature!");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("IT is warmer than room temperature!");
            //}
            //else if (currentTemperature < roomTemperature)
            //{
            //    Console.WriteLine("Room temperature is greater than current temeperature.")
            //}
            //else
            //{
            //    Console.WriteLine("It is not exaclty room temperature.")
            //}
        }
    }
}
