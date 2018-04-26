using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(powerN(3, 2));
            Console.ReadLine();
        }

        public static int powerN(int baseNumber, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            else
            {
                return baseNumber * powerN(baseNumber, exponent - 1);
            }
        }
    }
}
