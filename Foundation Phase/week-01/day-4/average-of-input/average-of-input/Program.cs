using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            Console.Write("Please enter a first number: ");
            double number = double.Parse(Console.ReadLine());

            Console.Write("Please enter a second number: ");
            number += double.Parse(Console.ReadLine());

            Console.Write("Please enter a third number: ");
            number += double.Parse(Console.ReadLine());

            Console.Write("Please enter a fourth number: ");
            number += double.Parse(Console.ReadLine());

            Console.Write("Please enter a fifth number: ");
            number += double.Parse(Console.ReadLine());

            Console.WriteLine("Sum: " + number + ", Average: " + number/5);

            Console.ReadLine();

        }
    }
}