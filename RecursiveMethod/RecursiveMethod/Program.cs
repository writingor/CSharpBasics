using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethod
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Recursion(3);

            //Factorial

            Console.WriteLine("FACTORIAL");
            Console.Write("Enter any number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int factorial = Factorial(userInput);
            Console.WriteLine(factorial);

            //exit
            Console.WriteLine("Enter any key to exit:");
            Console.ReadKey();
        }
        static void Recursion(int i)
        {
            i--;
            Console.WriteLine(i);
            if (i != 0)
            {
                Recursion(i);
            }
            Console.WriteLine(i);
            
        }

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(--n);
            }
        }
    }
}
