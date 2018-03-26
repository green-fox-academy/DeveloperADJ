using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!

            string myString = "BuuuuULlllIiiii";

            //IEnumerable<char> uppercaseChars = myString.Where(c => char.IsUpper(c));

            IEnumerable<char> uppercaseChars = from ch in myString
                                               where char.IsUpper(ch)
                                               select ch;

            foreach (var uppercaseChar in uppercaseChars)
            {
                Console.WriteLine(uppercaseChar);
            }

            Console.ReadLine();
        }
    }
}
