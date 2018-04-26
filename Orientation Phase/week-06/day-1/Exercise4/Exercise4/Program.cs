using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:

            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            IEnumerable<int> squaredValues = n.Select(x => x * x).Where(x => x > 20);

            foreach (var squaredValue in squaredValues)
            {
                Console.WriteLine(squaredValue);
            }

            Console.ReadLine();
        }
    }
}
