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

            Console.WriteLine("How big would you like the matrix to be? Please enter an integer number: ");
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (i == j)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;

                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}