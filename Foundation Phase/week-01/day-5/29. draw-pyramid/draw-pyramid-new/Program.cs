using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.Write("Please enter a number: ");
            int numberOfAsterisks = int.Parse(Console.ReadLine());
            int numberOfWhitespaces = numberOfAsterisks;
            string asterisk = "*";
            string whitespace = " ";

            for (int i = 0; i < numberOfAsterisks; i++)
            {

                for (int x = 0; x < numberOfWhitespaces; x++)
                {
                    Console.Write(whitespace);
                }

                numberOfWhitespaces -= 1;

                Console.WriteLine(asterisk);

                asterisk += "**";
            }
            Console.ReadLine();

        }
    }
}