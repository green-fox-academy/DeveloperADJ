using System;

namespace Bunny2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countBunnyEars(7));
            Console.ReadLine();
        }

        public static int countBunnyEars(int bunnies)
        {
            if (bunnies == 1)
            {
                if (bunnies % 2 == 0)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                if (bunnies % 2 == 0)
                {
                    return 3 + countBunnyEars(bunnies - 1);
                }
                else
                {
                    return 2 + countBunnyEars(bunnies - 1);
                }
            }
        }
    }
}
