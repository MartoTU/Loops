using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
namespace NumbersnotDivisible
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter value: ");
            int n = int.Parse(Console.ReadLine());
            int firstDivider = 3;
            int secondDivider = 7;
            for(int count=0 ; count<n ; count++)
            
            {
           if ((count % firstDivider == 0) || (count % secondDivider == 0))
           {
               continue;
           }
                   Console.WriteLine(" {0} ", count);
            }

        
            

            }
        }
    }

    
