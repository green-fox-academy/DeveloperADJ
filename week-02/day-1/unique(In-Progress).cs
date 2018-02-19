using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once

            //  Example
            //  Console.WriteLine(Unique({ 1, 11, 34, 11, 52, 61, 1, 34}));
            //  should print: `[1, 11, 34, 52, 61]`

            int[] ints = { 1, 11, 34, 11, 52, 61, 1, 34 };

            RemoveDuplicates(ints);
            Console.ReadLine();

        }

        public static int[] RemoveDuplicates(int[] arrayOfInts) {

            int[] filteredArray = new int[arrayOfInts.Length];

            for (int i = 0; i < arrayOfInts.Length; i++)
            {

                Console.WriteLine(arrayOfInts[i]);
            }

            return filteredArray;
        }


    }
}
