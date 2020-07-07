using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pg219logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your favorite line of poetry: ");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Log\log1.txt", text);
            string text2 = File.ReadAllText(@"C:\Log\log1.txt");
            Console.WriteLine(text2);
            Console.ReadLine();
        }
    }
}
