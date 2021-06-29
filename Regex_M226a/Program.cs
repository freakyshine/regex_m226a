using System;

namespace Regex_M226a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** ********************************** **\n" +
                              "** Welcome to the RegEx code example! **\n" +
                              "** ********************************** **");
            Console.WriteLine("**     What would you like to do?     **\n" +
                              "** * * * * * * * * * * * * * * * * *  **");

            AudibleExit(0);
        }
        /// <summary>
        /// The User Menu is used to display the menu and also contains the logic for the menu since it is not that complicated
        /// </summary>
        static void UserMenu()
        {

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
