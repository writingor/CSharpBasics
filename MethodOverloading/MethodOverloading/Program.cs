using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        #region Method overloading 

        // inclusive types, order, ref/out, quantity

        static void MethodOverloading(string value) { Console.WriteLine(value); }
        static void MethodOverloading(byte value) { Console.WriteLine(value); }
        static void MethodOverloading(byte value1, string value2) { Console.WriteLine($"{value1} {value2}"); }
        static void MethodOverloading(string value1, byte value2) { Console.WriteLine($"{value1} {value2}"); }
        static void MethodOverloading(ref string value1, byte value2) { Console.WriteLine($"{value1} {value2}"); }
        //static void MethodOverloading(out string value1, byte value2) { Console.WriteLine($"{value1} {value2}"); } out = ref
        //static string MethodOverloading(string value) { return value; } string or void is not overload
        static string MethodOverloading(string value1, string value2) { return value1 + value2; }


        #endregion

        static void Main(string[] args)
        {
            MethodOverloading("Hello!");
            MethodOverloading(1);
            MethodOverloading(1, "Hello!");
            MethodOverloading("Hello!", 1);

            string hello = MethodOverloading("Hello-", "hello!");
            MethodOverloading(ref hello, 1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Beep();
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
