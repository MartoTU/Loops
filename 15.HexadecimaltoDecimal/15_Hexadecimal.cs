using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Using loops write a program that converts a hexadecimal integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.
namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you hexadecimal value: ");
            string hexa = Console.ReadLine();

            long dec = long.Parse(hexa, NumberStyles.HexNumber);

            Console.WriteLine(dec);
        }
    }
}
