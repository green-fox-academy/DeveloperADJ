using System;
using System.Collections.Generic;
using System.IO;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts reversed-order.txt

            ReverseOrder("reversed-order.txt");
            Console.ReadLine();
        }


        public static void ReverseOrder(string file)
        {
            string[] lines = File.ReadAllLines(file);

            for (int i = lines.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(lines[i]);
            }
        }

    }
}