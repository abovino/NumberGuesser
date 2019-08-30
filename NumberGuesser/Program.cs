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

            GetAppInfo(); // Print the program info to cmd
            GreetUser(); // Ask users name and wish luck

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
                        PrintColorMsg(ConsoleColor.Red, "Please enter a number"); // Print error msg
                        continue;
                    }

                    // Cast to int and assign to userGuess
                    userGuess = Int32.Parse(input);

                    // Match guess to correct number
                    if (userGuess != correctNumber)
                    {
                        PrintColorMsg(ConsoleColor.Yellow, "Wrong number.  Please try again");
                    }
                }

                // Output success message
                PrintColorMsg(ConsoleColor.DarkGreen, "You are CORRECT!!!");

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

            PrintColorMsg(ConsoleColor.Green, $"{appName}: Version {appVersion} by {appAuthor} {authorHomepage}");
        }

        // Ask users name and wish them luck
        static void GreetUser()
        {
            string userName;

            Console.Write("Enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine($"Good luck, {userName}!");
        }

        // Print color message
        static void PrintColorMsg(ConsoleColor color, string msg)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
