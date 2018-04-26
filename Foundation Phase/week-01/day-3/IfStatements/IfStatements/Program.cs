using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello";

            int myNumber = 0;

            if (myNumber != 0)
            {
                Console.WriteLine("True");
            }
            else if(myString == "Hello")
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();
        }
    }
}
