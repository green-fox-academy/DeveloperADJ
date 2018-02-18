using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`

            int[] ai = new int[5]{3,4,5,6,7};




            Console.WriteLine(SumArray(ai));
            Console.ReadLine();
        }

        public static int SumArray(int[] array)
        {
            int arraySummed = 0;

            for (int i = 0; i < array.Length; i++)
            {
                arraySummed += array[i];
            }

            return arraySummed;
        }

    }
}