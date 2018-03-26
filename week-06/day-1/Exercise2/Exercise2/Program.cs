using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //IEnumerable<int> oddNumbers = n.Where(x => x % 2 == 1);

            IEnumerable<int> oddNumbers = from number in n
                                          where number % 2 == 1
                                          select number;


            double averageValue = oddNumbers.Average();

            foreach (var oddNumber in oddNumbers)
            {
                Console.WriteLine(oddNumber);
            }

            Console.WriteLine();
            Console.WriteLine(averageValue);
            Console.ReadLine();
        }
    }
}
