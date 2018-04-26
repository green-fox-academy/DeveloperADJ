using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to convert a char array to a string!

            var chars = new char[] {'A', 'r', 'n', 'o'};

            string name = String.Join("", chars);

            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
