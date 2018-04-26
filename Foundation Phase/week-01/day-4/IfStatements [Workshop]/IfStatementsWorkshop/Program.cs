using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementsWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = 8;

            if (randomNumber % 2 == 0)
            {
                if (randomNumber < 10)
                {
                    Console.WriteLine("This is a small even number.");
                }
                else if (randomNumber < 100){
                    Console.WriteLine("This is a medium even number.");
                }
                else
                {
                    Console.WriteLine("This is a big even number.");
                }
            }
            else
            {
                Console.WriteLine("This is an odd number.");
            }
                Console.ReadLine();
        }
    }
}
