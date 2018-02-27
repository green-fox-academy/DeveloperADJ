using System;
using System.Collections.Generic;
using System.IO;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts reversed-lines.txt

            ReverseLines("reversed-lines.txt");
          
            Console.ReadLine();
        }

        public static void ReverseLines(string file)
        {
            string[] allLines = File.ReadAllLines(file);

            foreach (var line in allLines)
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    Console.Write(line[i]);
                }

                Console.WriteLine();
            }
        }
    }
}