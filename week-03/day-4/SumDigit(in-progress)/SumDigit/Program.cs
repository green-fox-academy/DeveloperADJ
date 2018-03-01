using System;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write(SumDigits(126));

            //Console.WriteLine(12689 / 10000 % 10);
            //Console.WriteLine(12689 / 1000 % 10);
            //Console.WriteLine(12689 / 100 % 10);
            //Console.WriteLine(12689 / 10 % 10); 
            //Console.WriteLine(12689 % 10);

            Console.WriteLine(SumDigits(12345));

            Console.Read();
        }

        public static int SumDigits(int n)
        {
            
            Console.Write(n + " ");

            if (n == 0)
            {
                return 1;
            }
            else
            {
                return SumDigits(n / 10000 % 10);
                
            }
        }
    }
}
