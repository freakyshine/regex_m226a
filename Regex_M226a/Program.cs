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

            AudibleExit();
        }
        static void Menu()
        {

        }
        static void AudibleExit ()
        {
            Console.WriteLine("\nPress any key to exit the program.");
            Console.ReadKey();
        }
    }
}
