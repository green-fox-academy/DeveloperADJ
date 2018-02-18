using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer
            //     ^ ?
            while (true)
            {
                Console.WriteLine(Sum());
            }
        }




        public static int Sum()
        {
            Console.WriteLine("Please enter a number and the program will sum all the numbers up to that number: ");
            int userNumber = int.Parse(Console.ReadLine());
            int totalSum = 0;

            Console.Write("0");

            for (int i = 1; i </*=*/ userNumber; i++) //Uncomment the "=" to include the userNumber to the sum.
            {
                
                totalSum += i;
                Console.Write(" + {0}", i);

            }

            Console.Write(" = ");
            return totalSum;
        }
    }
}