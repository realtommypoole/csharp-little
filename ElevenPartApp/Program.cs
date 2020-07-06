using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ElevenPartApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ////-------------------- ARRAY --------------------//
            //string[] stringArray = { "jeb", "jim", "jan" };

            //Console.WriteLine("input some text");
            //string a = Console.ReadLine();

            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    stringArray[i] = stringArray[i] + a;
            //}

            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    Console.WriteLine(stringArray[i]);
            //}
            //Console.ReadLine();



            //---------------------infinite loop------------------//
            //int k = 0;
            //while (k < 5)
            //{
            //    Console.WriteLine(k);
            //    k--;
            //}

            //-----------------fixed loop---------------------------//
            //int k = 0;
            //while (k < 5)
            //{
            //    Console.WriteLine(k);
            //    k++;
            //}


            ////-----------------<  loop---------------------------//
            //int l = 0;
            //while (l < 5)
            //{
            //    Console.WriteLine(l);
            //    l++;
            //}


            ////-----------------<=  loop---------------------------//
            //int m = 0;
            //while (m <= 5)
            //{
            //    Console.WriteLine(m);
            //    k++;
            //}

            ////---------------------- List of Strings ---------------//
            //string[] greeting = { "hi", "hey", "hello", "hiya" };

            //Console.WriteLine("serach for an english greeting that starts with 'h': ");
            //string h = Console.ReadLine();

            //for (int i = 0; i < greeting.Length; i++)
            //{
            //    if (greeting[i] == h)
            //    {
            //        Console.WriteLine(i);
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wow, great job, that's not on the list! ");
            //    }
            //}

            ////---------------------- List of More Strings with More Loops ---------------//
            //string[] farewell = { "bye", "bonvoyage", "bubye", "bye" };

            //Console.WriteLine("serach for an english farewell that starts with 'b': ");
            //string f = Console.ReadLine();
            //bool z = false;

            //for (int k = 0; k < farewell.Length; k++)
            //    if (farewell[k] == f)
            //    {
            //        z = true;
            //    }


            //if (z == true)
            //{
            //    int i = 0;
            //    do
            //    {
            //        if (farewell[i] == f)
            //        {
            //            Console.WriteLine(i);
            //        }

            //        i++;
            //    }
            //    while (i < farewell.Length);
            //}

            //else
            //{
            //    Console.WriteLine("Wow, you thought of one not on the list!");
            //}
            //Console.Read();


            //---------------------- Comparing items in a list using CONTAINS ---------------//
            List<string> farewells = new List<string>() { "bye", "bonvoyage", "bye", "bya" };
            List<string> matches = new List<string>();

            foreach (string farewell in farewells)
            {
                if (matches.Contains(farewell))
                {
                    Console.WriteLine(farewell + " has already been seen");
                }
                else
                {
                    Console.WriteLine(farewell);
                    matches.Add(farewell);
                }

            }
            Console.ReadLine();


        }
    }
}
