using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesserProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Appinfo(); //running our info funkcion

            // Get users input
            Console.WriteLine("Please enter your name so we may begin: ");
            string input = Console.ReadLine();
            Console.WriteLine("Thank you {0} for joining and lets play", input);


            while (true)
            {

                Random random = new Random();
                int rightNumber = random.Next(1, 10);
                int numberGuess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                // While if guess is not correct
                while (numberGuess != rightNumber)
                {
                    string inputNumber = Console.ReadLine();

                    // Cheching if it is a number
                    if (!int.TryParse(inputNumber, out numberGuess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        continue;
                    }

                    numberGuess = Int32.Parse(inputNumber);

                    // Match guess to correct number
                    if (numberGuess != rightNumber)
                    {
                        // Error 
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!!");


                Console.WriteLine("would you like to Play Again?    [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                // If statement for playing again
                if (answer == "Y"){
                    continue;
                }
                else{
                    return;
                }

            }
        
        
        }
        // Funkcion for colours
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Appinfo() {
            string appName = "Number Guesser";
            string appAuthor = "Ivan Sambol";

            // Introduction
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("{0} Created by {1}", appName, appAuthor);
            Console.ResetColor();
            

        }
    }
}
