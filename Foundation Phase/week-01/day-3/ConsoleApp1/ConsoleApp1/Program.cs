using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Enter your name: ";
            string name;

            Console.Write(message);

            name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
            Console.ReadLine();

        }
    }
}
