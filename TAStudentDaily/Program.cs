using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("What is your name?");
        Console.ReadLine();
        string yourName = Console.ReadLine();
        Console.WriteLine("What course are you on?");
        string yourCourse = Console.ReadLine();
        Console.WriteLine("What page number?");
        string pageNum = Console.ReadLine();
        int pageNumb = Convert.ToInt32(pageNum);
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
        string yourHelp = Console.ReadLine();
        bool yourHelpp = Convert.ToBoolean(yourHelp);
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string yourExp = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you'd like to give? Please be specific.");
        string yourFeed = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string yourHours = Console.ReadLine();
        int yourHourss = Convert.ToInt32(yourHours);
        Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
        Console.ReadLine();
    }
}
