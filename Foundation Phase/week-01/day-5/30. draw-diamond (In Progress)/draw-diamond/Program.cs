using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            DrawTop(userNumber);
            Console.ReadLine();
        }

        private static void DrawTop(int userNumber)
        {
            string lineContent = string.Empty;

            int counter = 0;

            //Top half
            for (int i = 0; i < userNumber/2 + 1; i++)
            {
                lineContent = "";

                for (int k = userNumber - i; k > 0; k--)
                {
                    lineContent += " ";
                }

                for (int j = i; j > -1; j--)
                {
                    if (j == i)
                    {
                        lineContent += "*";
                    }
                    else
                    {
                        lineContent += "**";
                    }
                }
                Console.WriteLine(lineContent);

                counter = i;
            }
           
            for (int l = 0; l < counter; l++)
            {
                for (int m = l; m > -1; m--)
                {
                        Console.Write(" ");
                }

                for (int n = userNumber - l; n > 0; n--)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
        }
    }
}