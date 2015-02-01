using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
namespace _12.RandomNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("min = ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("max = ");
            int max = int.Parse(Console.ReadLine());

            if (min <= max)
            {
                Random random = new Random();

                for (int i = 0; i < n; i++)
                {
                    Console.Write(random.Next(min, max + 1) + " ");
                }

                Console.WriteLine();
            }
        }
    }
}