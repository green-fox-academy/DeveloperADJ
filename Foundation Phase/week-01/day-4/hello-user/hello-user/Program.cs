using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user
            Console.Write("Hello, what is your name? ");
            string username = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", username);
            Console.ReadLine();

        }
    }
}