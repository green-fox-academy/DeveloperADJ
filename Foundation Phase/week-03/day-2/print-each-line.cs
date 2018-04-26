using System;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"

            try
            {
                string myFileURL = "my-file.txt";

                string[] myFilesLines = File.ReadAllLines(myFileURL);

                foreach (var line in myFilesLines)
                {
                    Console.WriteLine(line);
                }
            }
            catch
            {

                Console.WriteLine("Unable to read file: my-file.txt");
            }
            finally
            {
                Console.Read();
            } 
        }
    }
}
