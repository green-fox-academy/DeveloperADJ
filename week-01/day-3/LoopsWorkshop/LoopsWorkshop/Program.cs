using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = 0;
            while (randomNumber < 100)
            {
                //randomNumber = randomNumber + 1;
                randomNumber += 10;
                //randomNumber++;
                Console.WriteLine(randomNumber);
            }

            Console.ReadLine();
        }
    }
}
