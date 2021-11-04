using System;
/*
 Write a program named Averages that includes a method that accepts any number of 
numeric parameters, displays them, and displays their average. Demonstrate that the 
method works correctly when passed one, two, or three numbers, or an array of numbers.
 */

namespace question7chapter8
{
    class Program
    {
        static void Main(string[] args)
        {
            getAverage(1, 2, 3,4,5,6,7,8,9,10);
        }

        public static void getAverage(params double[] nums)
        {
            double total = 0;
            foreach(double num in nums)
            {
                Console.WriteLine(num);
                total += num;
            }
            Console.WriteLine("......................................................");

            double average = total / nums.Length;
            Console.WriteLine($"The average is {average}");

        }
    }
}
