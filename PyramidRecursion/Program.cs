﻿using System;

namespace PyramidRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            do
            {
                Console.WriteLine("Enter odd number bigger than 2");
                number = int.Parse(Console.ReadLine());
            } while (number <= 2 && number%2!=0 );

            Pyramid(number, 0);
        }

        static void Pyramid(int n, int r)
        {
            if (n == -1)
            {
                return;
            }   
                //print space from left
                for (int j = 0; j < r; j++)
                {
                    Console.Write(" ");
                }
                //print cross
                for (int j = 0; j < n; j++)
                {
                    Console.Write("x");
                }
               
            Console.WriteLine();
            r++;                  
            Pyramid(n-2, r);
        }
    }
}
