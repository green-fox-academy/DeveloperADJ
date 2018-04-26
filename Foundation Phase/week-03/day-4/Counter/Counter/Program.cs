using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Counter(10));
            Console.ReadLine();
        }

        public static int Counter(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                Console.Write(n + ", ");
                return Counter(n - 1);
            }
        }
    }
}
