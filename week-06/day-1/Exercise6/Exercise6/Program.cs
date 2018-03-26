using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of characters in a given string!

            string name = "Allejandro";

            IEnumerable<int> frequencyOfChars = name.ToLower().GroupBy(x => x).Select(x=>x.Count());

            foreach (var chars in frequencyOfChars)
            {
                Console.WriteLine(chars);
            }

            Console.ReadLine();
        }
    }
}
