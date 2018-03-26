using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> squaredNumbers = n.Where(x => x > -1).Select(x => x * x);

            foreach (var squaredNumber in squaredNumbers)
            {
                Console.WriteLine(squaredNumber);
            }

            Console.ReadLine();
        }
    }
}
