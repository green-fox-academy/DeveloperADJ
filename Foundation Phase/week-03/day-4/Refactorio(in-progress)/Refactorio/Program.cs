using System;

namespace Refactorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a recursive function called `refactorio`
            // that returns it's input's factorial
            //input 120 needs to output 5
            Console.WriteLine(Refactorio(5));
            Console.ReadLine();
        }

        public static int Refactorio(int n)
        {
            Console.WriteLine(n);
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Refactorio(n - 1);
            }
        }
    }
}
