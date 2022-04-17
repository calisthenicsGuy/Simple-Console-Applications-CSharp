using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Simple_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("              Number Guesser: Version 1.0.1 by Radoslav Radev");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Enter your username: ");
            string usernameOfThePlayer = Console.ReadLine();

            Console.WriteLine($"Hello {usernameOfThePlayer}, let's play a game...");
            

            GameFunction();
        }

        private static void GameFunction()
        {

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Guess a number between 1 and 100");

            var random = new Random();
            int correctNumber = random.Next(1, 100);
            int guessingNumber = int.Parse(Console.ReadLine());

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong number, Please try again");
                Console.ForegroundColor = ConsoleColor.Green;

                if (guessingNumber > correctNumber)
                {
                    Console.WriteLine($"The correct number is less than {guessingNumber}");
                }
                else if (guessingNumber < correctNumber)
                {
                    Console.WriteLine($"The correct number is greater than {guessingNumber}");
                }

                guessingNumber = int.Parse(Console.ReadLine());
            } while (guessingNumber != correctNumber);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CORRECT!! You guessed it!");
            Console.WriteLine();
            EndGame();
        }
        private static void EndGame()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Play Again?  [Y or N]");
            string command = Console.ReadLine().ToUpper();

            if (command == "Y")
            {
                GameFunction();
            }
            else
            {
                return;
            }
        }
    }
}
