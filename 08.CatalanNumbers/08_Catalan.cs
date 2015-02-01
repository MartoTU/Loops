using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
// Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
 
        if (n > 1 && n < 100)
        {
            BigInteger multiFactN = 1;
            BigInteger plusFactN = 1;
            BigInteger factN = 1;
            BigInteger result = 0;
 
            for (int i = 1; i <= 2 * n; i++)
            {
                multiFactN *= i;
            }
 
            for (int j = 1; j <= n + 1; j++)
            {
                plusFactN *= j;
            }
 
            for (int k = 1; k <= n; k++)
            {
                factN *= k;
            }
 
            result = multiFactN / (plusFactN * factN);
 
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
        }
    

