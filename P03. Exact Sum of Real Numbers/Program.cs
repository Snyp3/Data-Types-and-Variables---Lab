﻿namespace P03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enterNumbers = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 1; i <= enterNumbers; i++)
            {
            decimal number = decimal.Parse(Console.ReadLine());
                total += number;           
            }
            Console.WriteLine(total);
        }
    }
}