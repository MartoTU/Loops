﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
namespace MinMaxSumAvv
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            double sum = 0;
            double avg = 0;

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                min = Math.Min(min, number);
                max = Math.Max(max, number);
                sum += number;
                avg = sum / count;
            }

            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Avg = {0:F2}", avg);
        }
    }
}

