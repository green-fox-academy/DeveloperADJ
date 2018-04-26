using System;
using System.Collections.Generic;
using System.IO;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt 

            decrypt("duplicated-chars.txt");
            Console.ReadLine();

        }

        public static void decrypt(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    throw new Exception("File not found! :(:(:(");
                }

                string[] lines = File.ReadAllLines(fileName);

                for (int i = 0; i < lines.Length; i++)
                {
                    for (int j = 0; j < lines[i].Length; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(lines[i][j]);
                        }
                    }
                    Console.WriteLine("");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

    }
}