using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was


            Console.WriteLine("Please enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            string top = "";
            string between = "";
            string bottom = "";


            if (userNumber > 1)
            {

                //Top Row
                for (int i = 0; i < userNumber; i++)
                {
                    top += "%";
                }

                Console.WriteLine(top);

                //Inbetween
                for (int x = 0; x < userNumber - 2; x++)
                {
                    between = "";

                    between += "%";

                    for (int y = 0; y < userNumber - 2; y++)
                    {
                        between += " ";
                    }

                    between += "%";

                    Console.WriteLine(between);
                }

                //Bottom Row
                for (int i = 0; i < userNumber; i++)
                {
                    bottom += "%";
                }

                Console.WriteLine(bottom);
            }


            Console.ReadLine();
        }
    }
}