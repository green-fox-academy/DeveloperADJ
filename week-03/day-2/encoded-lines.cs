using System;
using System.Collections.Generic;
using System.IO;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts encoded-lines.txt

            string file = "encoded-lines.txt";

            DecodeLines(file);
        }

        public static void DecodeLines(string file) {

            string[] lines = File.ReadAllLines(file);

            List<char> chars = new List<char>();

            for (int i = 0; i < lines.Length; i++)
            {   
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == ' ')
                    {
                        chars.Add(' ');
                    }
                    else
                    {
                        char shiftedChar = (char)((int)lines[i][j] - 1);
                        chars.Add(shiftedChar);
                    }
                }
                chars.Add('\n');
            }
            
            foreach (var ch in chars)
            {
                Console.Write(ch);
            }
            
            Console.ReadLine();
        }


    }
}