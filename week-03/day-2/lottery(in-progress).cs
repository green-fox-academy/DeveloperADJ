using System;
using System.Collections.Generic;
using System.IO;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that find the 5 most common lottery numbers in lottery.csv

            string file = "lottery.csv";
            //There are always 4 ';' semicolons before the Ft Amount.

            MostCommonLotteryNumbers(file);
        }

        public static void MostCommonLotteryNumbers(string file)
        {
            string[] lines = File.ReadAllLines(file);

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i].Substring(lines[i].Length - 10, 10);
            }

            Console.ReadLine();
        }
    }
}