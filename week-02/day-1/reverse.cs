using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            //[7,6,5,4,3]


            int[] aj = { 3, 4, 5, 6, 7 };
            int[] ja = new int[aj.Length];
            aj.CopyTo(ja, 0);

            for (int i = 0, j = aj.Length-1; i < aj.Length; i++, j--)
            {
                aj[i] = ja[j];
                Console.Write(aj[i]);
            }

            Console.ReadLine();
        }
    }
}