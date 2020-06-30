using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.ReadLine();
        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();
        Console.WriteLine("What course are you on?");
        string yourCourse = Console.ReadLine();
        Console.WriteLine("What page number?");
        int pageNum = Console.ReadLine();
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
        bool yourHelp = Console.ReadLine();
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string yourExp = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you'd like to give? Please be specific.");
        string yourFeed = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        int yourHours = Console.ReadLine();
        Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
        Console.ReadLine();
    }
}

