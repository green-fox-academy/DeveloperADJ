using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
            Console.WriteLine("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            string asterisk = "*";
            string oneMoreAsterisk = "*";

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(asterisk);
                asterisk += oneMoreAsterisk;
            }


            Console.ReadLine();
        }
    }
}