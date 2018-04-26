using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:

            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            IEnumerable<int> frequencyOfNumbers = n.GroupBy(x => x).Select(x => x.Count());

            //IEnumerable<int> frequencyOfNumbers = (from number in n
            //                                       group number by number
            //                                       into frequency
            //                                       select frequency.Count());

            foreach (var frequencyOfNumber in frequencyOfNumbers)
            {
                Console.WriteLine(frequencyOfNumber);
            }

            Console.ReadLine();
        }
    }
}
