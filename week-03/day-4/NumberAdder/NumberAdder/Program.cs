using System;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(numberAdder(10));
            Console.Read();
        }

        public static int numberAdder(int n)
        {
            Console.Write(n);
            if (n == 1)
            {
                Console.Write(" = ");
                return 1;
            }
            else
            {
                Console.Write(" + ");
                return n + numberAdder(n - 1);
            }
        }


    }
}
