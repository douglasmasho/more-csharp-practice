using System;
/*Create a program named IntegerFacts whose Main() method declares an array of 
10 integers. Call a method to interactively fill the array with any number of values up 
to 10 or until a sentinel value is entered. If an entry is not an integer, reprompt the 
user. Call a second method that accepts out parameters for the highest value in the 
array, lowest value in the array, sum of the values in the array, and arithmetic average. 
In the Main() method, display all the statistics.*/

namespace question2chapter8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[10];
            FillArr(intArr);
            Console.WriteLine("termination of loop");
            int highest, lowest, sum;
            double average;
            getStats(out highest, out lowest, out sum, out average, intArr);
            Console.WriteLine($"{highest},{lowest},{sum},{average}");
        }

        public static void FillArr(params int[] numArr)
        {
            int i = 0;
            Console.WriteLine(numArr.Length);
            //q is the sentinel value
            while(i < 10)
            {
                Console.WriteLine("Please enter an integer to put in the array, press q to stop");
                string filledValue = Console.ReadLine();
                int filledValueNum;
                int.TryParse(filledValue, out filledValueNum);
                if(filledValue == "q")
                {
                    break;
                }else if(filledValueNum == 0)
                {
                    Console.WriteLine("Please enter an integer, you aint slick");
                }
                else
                {
                    numArr[i] = filledValueNum;
                    i++;
                }

            }
        }

       public static void getStats(out int highest, out int lowest, out int sum, out double average, params int[] numArr)
        {
            //get the maximum and mimimum
            double highestNum = double.NegativeInfinity;
            double lowestNum = double.PositiveInfinity;
            int total = 0;
            foreach (int num in numArr)
            {
                Console.WriteLine($"{num}, {highestNum}");
                if (num > lowestNum)
                {
                    highestNum = num;
                }
                if (num < highestNum)
                {
                    lowestNum = num;
                }
                total += num;
            }
            highest = 10;
            lowest = 0;
            sum = total;
            average = (double)total / numArr.Length;
        }
    }
}
