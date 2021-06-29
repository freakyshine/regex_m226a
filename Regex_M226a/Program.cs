using System;
using System.Threading;

namespace Regex_M226a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** ********************************** **\n" +
                              "** Welcome to the RegEx code example! **\n" +
                              "** ********************************** **");
            Thread.Sleep(1500); // Keep Thread idle for 1.5s

            // Call menu
            UserMenu();

            AudibleExit(0);
        }
        /// <summary>
        /// The User Menu is used to display the menu and also contains the logic for the menu since it is not that complicated
        /// </summary>
        static void UserMenu()
        {
            ConsoleKey userInput;
            byte menuPointer = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("** * * * * * * * * * * * * * * * * *  **\n" +
                                  "**     What would you like to do?     **\n" +
                                  "** * * * * * * * * * * * * * * * * *  **");
                Console.Write($"[{(menuPointer == 0 ? '*': ' ')}] Option 1\n" +
                              $"[{(menuPointer == 1 ? '*' : ' ')}] Option 2\n" +
                              $"[{(menuPointer == 2 ? '*' : ' ')}] Option 3");
                userInput = Console.ReadKey().Key;
                switch (userInput)
                {
                    case ConsoleKey.UpArrow:
                        menuPointer--;
                        break;
                    case ConsoleKey.DownArrow:
                        menuPointer++;
                        break;
                    default:
                        break;
                }
                menuPointer = (byte)(menuPointer > 3 ? 2 : menuPointer);
                menuPointer %= 3;
            } while (userInput != ConsoleKey.Enter);
            Console.WriteLine("[]");
            Console.Clear();
        }
        /// <summary>
        /// The audible exit method keeps the console from just closing like that. It tells the user the program has ended and prompt the user to enter a key. Then the program will be exited by the method
        /// </summary>
        /// <param name="exitCode">
        /// The exit code with which the program will be exited
        /// </param>
        static void AudibleExit (int exitCode)
        {
            Console.WriteLine("\nPress any key to exit the program.");
            Console.ReadKey();
            Environment.Exit(exitCode);
        }
    }
}
