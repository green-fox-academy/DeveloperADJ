using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("% % % % % % % %");
                Console.WriteLine(" % % % % % % % ");
            }


            Console.ReadLine();
        }
    }
}