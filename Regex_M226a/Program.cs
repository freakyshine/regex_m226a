using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace Regex_M226a
{
    class Program
    {
        private static Regex passwordRegEx = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[\W])[A-Za-z\d\W]{8,}$");
        private static Regex digits = new Regex(@"[\d]{1,}");
        private static Regex romanLetters = new Regex(@"[A-Za-z]{1,}");
        private static Regex symbols = new Regex(@"[\W]{1,}");

        static void Main(string[] args)
        {
            Console.WriteLine("** ********************************** **\n" +
                              "** Welcome to the RegEx code example! **\n" +
                              "** ********************************** **");
            Thread.Sleep(1500); // Keep Thread idle for 1.5s

			// Todo: Implement loading screen

			// Call menu
			switch (UserMenu())
			{
                case 0:
                    PasswordExample();
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
					break;
			}

            AudibleExit(0);
        }
        /// <summary>
        /// The User Menu is used to display the menu and also contains the logic for the menu since it is not that complicated
        /// </summary>
        static byte UserMenu()
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
            Console.Clear();
            return menuPointer;
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
        /// <summary>
        /// Output the example for password regex
        /// </summary>
        static void PasswordExample()
        {
            Console.WriteLine("** ********************************** **\n" +
                              "**    Example RegEx for passwords     **\n" +
                              "** ********************************** **");
            Console.WriteLine("Enter a password:");
            string newPassword = Console.ReadLine();
            
			while (!passwordRegEx.IsMatch(newPassword))
			{
                Console.Clear();
                Console.WriteLine("Password is not secure enough");
                Console.WriteLine("Criteria:\n" +
                                  $"[{(!romanLetters.IsMatch(newPassword) ? ' ' : 'X')}] Contain at least 1 letter\n" +
                                  $"[{(!digits.IsMatch(newPassword) ? ' ' : 'X')}] Contain at least 1 digit\n" +
                                  $"[{(!symbols.IsMatch(newPassword) ? ' ' : 'X')}] Contain at least 1 special character");
                
                Console.WriteLine("Enter a password:");
                newPassword = Console.ReadLine();
            }
            Console.Clear();
            Console.Write("Your password is set to: ");
			for (int i = 0; i < newPassword.Length; i++)
			{
                Console.Write("*");
			}
        }
    }
}
