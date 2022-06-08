using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var even = new List<int>();
            var odd = new List<int>();

            for(int x=0; x<numbers.Length; x++)
            {
                if(numbers[x] % 2== 0)
                {
                    even.Add(numbers[x]);
                }
                else
                {
                    odd.Add(numbers[x]);
                }
            }
            Console.WriteLine("Even numbers:");
            foreach (var num in even)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Odd numbers:");
            foreach (var num in odd)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
