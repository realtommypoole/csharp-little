using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numList = new List<int>() { 1, 2, 6, 658 };
            Console.WriteLine("Pick a number.");
            string numberOne = Console.ReadLine();

            try
            {
                foreach (int number in numList)
                {
                    int numberOner = Convert.ToInt32(numberOne);
                    Console.WriteLine(number / numberOner);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("The program has emerged from the try/catch block");
                Console.ReadLine();
            }

        }
    }
}
