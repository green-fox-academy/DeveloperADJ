using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            int sideA = 5;
            int sideB = 6;
            int sideC = 7;

            int surfaceArea = (2 * sideA * sideB) + (2 * sideB * sideC) + (2 * sideC * sideA);
            int volume = sideA * sideB * sideC;

            Console.WriteLine("surfaceArea Area: " + surfaceArea);
            Console.WriteLine("Volume: " + volume);

            Console.ReadLine();


        }
    }
}