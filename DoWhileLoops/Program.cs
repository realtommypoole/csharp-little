using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 or 2: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("Guess a three letter name that starts with 'j'");
                string name = Console.ReadLine();
                bool isGuessedN = name == "jeb";
                
                while (!isGuessedN)
                    {
                    switch (name)
                    {
                        case "jan":
                            Console.WriteLine("You guessed 'jan'. Try again.");
                            Console.WriteLine("Guess a three letter name that starts with 'j'");
                            name = Console.ReadLine();
                            break;

                        case "jay":
                            Console.WriteLine("You guessed Jay. Try again.");
                            Console.WriteLine("Guess a three letter name that starts with 'j'");
                            name = Console.ReadLine();
                            break;

                        case "jeb":
                            Console.WriteLine("You guessed 'jeb'. You got it! Hit exit to leave.");
                            name = Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("the name " + name + " is incorrect. Guess again.");
                            name = Console.ReadLine();
                            break;


                    }
                }
            }


            else if (a == 2)
            {
                Console.WriteLine("Guess a number between 1 and 7");
                int number = Convert.ToInt32(Console.ReadLine());
                bool isGuessed = number == 7;

                do
                {
                    switch (number)
                    {
                        case 2:
                            Console.WriteLine("You guessed 2. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("You guessed 3. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("You guessed 5. Try again.");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("You gussed 7. You got it right!");
                            isGuessed = true;
                            break;
                        default:
                            Console.WriteLine("You are wrong");
                            Console.WriteLine("Guess a number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }

                while (!isGuessed);

                Console.Read();

            }

        }
    }
}
