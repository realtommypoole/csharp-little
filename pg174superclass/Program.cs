using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg174superclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.FirstName = "Steve";
            emp1.LastName = "St";
            emp1.Id = 489;
            emp1.SayName();

            Employee emp2 = new Employee();
            emp2.FirstName = "Ernie";
            emp2.LastName = "Two";
            emp2.Id = 489;
            emp2.SayName();

            //bool x = emp2.Id == emp1.Id;
            //Console.WriteLine(x);


            if (emp1 == emp2)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
            Console.ReadLine();
        }
    }
}
