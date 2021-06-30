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
        private static Regex email = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        private static Regex spuderman = new Regex(@"Spider([\- ]?)man", RegexOptions.IgnoreCase);

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
                    SpuderManExample();
                    break;
                case 1:
                    EmailExample();
                    break;
                case 2:
                    PasswordExample();
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
                Console.Write($"[{(menuPointer == 0 ? '*': ' ')}] Spuderman\n" +
                              $"[{(menuPointer == 1 ? '*' : ' ')}] E-EEEE EEEEEEEE EEEEEEEEEE\n" +
                              $"[{(menuPointer == 2 ? '*' : ' ')}] Password Validation");
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
        /// This method contains and displays the use of regex for accepting multiple spelling of words
        /// </summary>
        static void SpuderManExample()
        {
            Console.WriteLine("Try searching for the nick name of Peter Parker");
            string searchQuery = Console.ReadLine();
			while (!spuderman.IsMatch(searchQuery))
            {
                Console.Clear();
                Console.WriteLine($"I don't think {searchQuery} is an alias for Peter Parker.");
                Console.Write($"Try again: ");
                searchQuery = Console.ReadLine();
            }
        }
        /// <summary>
        /// This method contains and displays the use of regex in relation to password validation
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
        /// <summary>
        /// This method contains and displays the use of regex in relation to the validation of E-Mail Addresses
        /// </summary>
        static void EmailExample()
        {
            Console.WriteLine("** ********************************** **\n" +
                              "** Example RegEx for email validation **\n" +
                              "** ********************************** **");
            Console.WriteLine("Enter an email address:");
            string newEmail = Console.ReadLine();

            while (!email.IsMatch(newEmail))
            {
                Console.Clear();
                Console.WriteLine("This is not a valid email address");

                Console.WriteLine("Enter an email address:");
                newEmail = Console.ReadLine();
            }
            Console.Clear();
            Console.Write($"Your email address is set to: {newEmail}");
        }
    }
}
