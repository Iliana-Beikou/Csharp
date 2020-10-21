using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public static int factorial(int n)
        {
            if (n == 1 ) 
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial(x));

        }
    }
}
