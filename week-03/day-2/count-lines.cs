using System;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            int countLinesInFile(string fileName){

                int numberOfLines = 0;

                try
                {
                    string[] fileLines = File.ReadAllLines(fileName);
                    foreach (var line in fileLines)
                    {
                        numberOfLines += 1;
                    }
                }
                catch (Exception)
                {

                    numberOfLines = 0;
                }

                return numberOfLines;
            }

            Console.WriteLine(countLinesInFile("my-file.txt"));
            Console.Read();
        }
    }
}
