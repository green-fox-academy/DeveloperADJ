using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatementsWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = 9;

            switch (randomNumber % 2)
            {
                case 0:
                    Console.WriteLine("This is an even number.");
                    break;
                default:
                    Console.WriteLine("This is an odd number.");
                    break;
                
    
            }

            Console.ReadLine();
        }
    }
}
