using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ...
            Console.WriteLine("Who are you?: ");
            string firstString = Console.ReadLine();

            Console.WriteLine("What do you love doing?: ");
            string secondString = Console.ReadLine();

            Console.WriteLine("Who do you look up to?: ");
            string thirdtString = Console.ReadLine();

            Console.WriteLine("What is your favourite location?: ");
            string fourthString = Console.ReadLine();

            Printer(firstString, secondString, thirdtString, fourthString);

            Console.ReadLine();
        }

        public static void Printer(string first, string second, string third, string fourth)
        {
            Console.WriteLine("{0} is {1} with {2} in {3}", first, second, third, fourth);
        }

    }
}