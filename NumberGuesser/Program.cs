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
            Random random = new Random();
            int userGuess = 0;
            
            string userWantsToContinue;
            int correctNumber;

            GetAppInfo();

            Greeting();

            while (true)
            {
                // Set correct number
                correctNumber = random.Next(1, 10);

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (userGuess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Validate user input
                    if (!int.TryParse(input, out userGuess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a number");
                        Console.ResetColor();

                        continue;
                    }

                    // Cast to int and assign to userGuess
                    userGuess = Int32.Parse(input);

                    // Match guess to correct number
                    if (userGuess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Wrong number, please try again");
                        Console.ResetColor();
                    }
                }

                // Output success message
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You are CORRECT!!!");
                Console.ResetColor();

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");
                userWantsToContinue = Console.ReadLine().ToUpper();

                if (userWantsToContinue == "Y")
                {
                    continue;
                }
                else if (userWantsToContinue == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // Prints program info to the console
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Angelo Bovino";
            string authorHomepage = "https://angelobovino.me";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor} {authorHomepage}");
            Console.ResetColor();
        }

        // Get the users name and wish them luck
        static void Greeting()
        {
            string userName;

            // Get users name
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine($"Good luck, {userName}!");
        }
    }
}
