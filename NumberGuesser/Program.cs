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

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor} {authorHomepage}");

            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
