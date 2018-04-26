using System;
using System.Collections.Generic;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            string file1 = "my-file.txt";
            string file2 = "copy-file.txt";
            Console.WriteLine(CopyFileContent(file1, file2));
            Console.Read();

            bool CopyFileContent(string fromFile, string toFile)
            {
                bool copySuccessful;

                try
                {
                    string[] allLines = File.ReadAllLines(fromFile);

                    File.WriteAllLines(file2, allLines);

                    copySuccessful = true;
                }
                catch
                {
                    copySuccessful = false;
                }

                return copySuccessful;
            }
        }
    }
}