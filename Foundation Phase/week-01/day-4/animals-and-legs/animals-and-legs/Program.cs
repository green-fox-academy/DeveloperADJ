using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
            Console.Write("How many chickens does the farmer have? ");
            int numberOfChickenLegs = int.Parse(Console.ReadLine()) * 2;

            Console.Write("How many pigs does the farmer have? ");
            int numberOfPigLegs = int.Parse(Console.ReadLine()) * 4;

            int totalNumberOfLegs = numberOfChickenLegs + numberOfPigLegs;

            Console.WriteLine("The animals have " + totalNumberOfLegs + " legs in total");
            Console.ReadLine();
            
        }
    }
}