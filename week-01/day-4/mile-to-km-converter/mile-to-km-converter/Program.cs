using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            Console.WriteLine("Please enter a value in Kilometers here: ");
            double kilometers = double.Parse(Console.ReadLine());
            double miles = kilometers * 0.621371192;
            Console.WriteLine("Thats " + miles + " miles.");
            Console.ReadLine();


        }
    }
}