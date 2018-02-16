using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.Write("How many numbers would you like to enter? ");
            int numberOfIntegers = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 0; i < numberOfIntegers; i++)
            {
                Console.Write("Please enter a number: ");
                total += double.Parse(Console.ReadLine());

            }

            Console.WriteLine("Sum: " + total + ", Average: " + (total/numberOfIntegers));

            Console.ReadLine();
        }
    }
}