using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Angelo Bovino";
            string authorHomepage = "https://angelobovino.me";
            int userGuess = 0;
            string userName;
            int correctNumber;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor} {authorHomepage}");

            Console.ResetColor();

            // Get users name
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            Console.WriteLine($"Good luck, {userName}!");

            // Set correct number
            correctNumber = 7;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            while (userGuess != correctNumber)
            {
                // Get users input
                string input = Console.ReadLine();

                // Cast to int and assign to userGuess
                userGuess = Int32.Parse(input);

                // Match guess to correct number
                if (userGuess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Wrong number, please try again");

                    Console.ResetColor();
                }
            }

            Console.ReadLine();
        }
    }
}
