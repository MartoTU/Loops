using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
// Use the Euclidean algorithm (find it in Internet).
namespace Calculate_GCD
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            int c = 0;

            while (b != 0)
            {
                c = b;
                b = a % b;
                a = c;
            }

            Console.WriteLine(a);
        }
    }
}
