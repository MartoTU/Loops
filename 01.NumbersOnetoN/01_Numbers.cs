using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
namespace NumbersOnetoN
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number of numerals you want to see: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while(count<=n)
            {
           Console.Write(" {0} ", count);
                count++;
            }     
        }
    }
}
