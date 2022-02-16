using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, World!");
            }
            finally
            {
                Console.Beep();

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Press any key to close the program:");
                Console.ReadKey();
            }
        }
    }
}
