using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg230GUID
{
    class Program
    {

        static void Main(string[] args)
        {

            const string gameName = "The Most Dangerous Game";
            Console.WriteLine(gameName);
            Console.WriteLine("What is your weight?");
            var w = Console.ReadLine();
            Student student1 = new Student(433);
            Student student2 = new Student();
            Console.WriteLine(student1.id);
            Console.WriteLine(student2.id);
            Console.ReadLine();
        }
    }
}
