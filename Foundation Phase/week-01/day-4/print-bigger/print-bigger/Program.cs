using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Please enter a first number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("The biggest number is: ");

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
            




            Console.ReadLine();

        }
    }
}