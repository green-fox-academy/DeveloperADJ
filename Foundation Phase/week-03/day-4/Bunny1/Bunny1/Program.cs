using System;

namespace Bunny1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countBunnyEars(3));
            Console.ReadLine();
        }

        public static int countBunnyEars(int bunnies)
        {
            if (bunnies == 1)
            {
                return 2;
            }
            else
            {   
                return 2 + countBunnyEars(bunnies - 1);
            }
        }
    }
}
