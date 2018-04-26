using System;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

            string file = "my-file.txt";

            try
            {
                if (!File.Exists(file))
                {
                    throw new Exception("Unable to write file: my-file.txt");
                }

                using (StreamWriter sw = new StreamWriter(file))
                {
                    sw.WriteLine("Arno");
                }

                Console.WriteLine("Wrote to file");
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.Read();
            }

        }
    }
}
