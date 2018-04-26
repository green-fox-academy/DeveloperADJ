using System;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumDigits(123));
            Console.Read();
        }

        public static int SumDigits(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return (n % 10) + SumDigits(n / 10);
            }
        }
    }
}
