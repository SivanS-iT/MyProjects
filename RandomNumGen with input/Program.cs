using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumGenerator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Appinfo();

            //  int number2 = 0;

            Console.WriteLine("\xA Write your min and max number in which you want to roll");

            Console.WriteLine("Your 1. number:");
            string num1 = Console.ReadLine();
            int number1;
            int number2;

            while (true)
            {

                // checking if the inpput is a number
                while (true)
                {
                    if (!int.TryParse(num1, out number1))
                    {
                        Console.WriteLine("Thats not a number! ");
                        num1 = Console.ReadLine();
                    }
                    if (int.TryParse(num1, out number1) == true) break;
                }

                Console.WriteLine("Your 2. number:");
                string num2 = Console.ReadLine();
                while (true)
                {
                    if (!int.TryParse(num2, out number2))
                    {
                        Console.WriteLine("Thats not a number! try again ");
                        num2 = Console.ReadLine();
                    }
                    if (int.TryParse(num2, out number2) == true) break;
                }

                Random rnd = new Random();
                int dice;


                // checking which input is greater
                if (number1 > number2)
                {
                    dice = rnd.Next(number2, number1);
                }
                else
                {
                    dice = rnd.Next(number1, number2);
                }
                Console.WriteLine("Random number is --------> {0}", dice);



                Console.WriteLine("would you like to Play Again?    [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                // If statement for playing again
                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }

            }
        }

        
        static void Appinfo()
        {
            string appName = "Random number generator";
            string appAuthor = "Ivan Sambol";

            // Introduction
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcomen to {0} ----- Created by {1}", appName, appAuthor);
            Console.ResetColor();
        }
    }
}
