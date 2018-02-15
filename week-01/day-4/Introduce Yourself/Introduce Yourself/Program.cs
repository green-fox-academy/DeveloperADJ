using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints a few details to the terminal window about you
            // It should print each detail to a new line.
            //  - Your name
            //  - Your age
            //  - Your height in meters (as a decimal fraction)
            //
            //  Example output:
            //  John Doe
            //  31
            //  1.87
            string name = "Arno";
            int age = 28;
            float height = 1.82f;

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Height: {0}m", height);

            Console.ReadLine();

        }
    }
}