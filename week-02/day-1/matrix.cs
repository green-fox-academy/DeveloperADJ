using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
            int userNumber = int.Parse(Console.ReadLine());

            int[] matrix = new int[userNumber];

            for (int i = 0; i < matrix.Length; i++)
            {
                if (i % 5 == 0)
                    matrix[i] = 1;
                else
                    matrix[i] = 0;
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                if ((i + 1) % 4 == 0)
                    Console.WriteLine(matrix[i]);
                else
                    Console.Write(matrix[i]);
            }

            Console.ReadLine();
        }
    }
}