using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            string al = "GreenFox";

            // - Create a function called `greet` that greets it's input parameter

            Greet(al);

            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`
            Console.ReadLine();
        }

        public static void Greet (string inputString)
        {
            Console.WriteLine("Greetings dear, {0}", inputString);
        }
    }
}