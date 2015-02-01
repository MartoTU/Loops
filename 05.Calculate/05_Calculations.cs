using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
// Use only one loop. Print the result with 5 digits after the decimal point.
namespace Calculate
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());

            double factN = 1;
            double multiX = 1;
            double result = 1;

            for (int i = 1; i <= n; i++)
            {
                factN *= i;
                multiX *= x;
                result += factN / multiX;
            }

            Console.WriteLine("{0:F5}", result);
        }
    }
}
