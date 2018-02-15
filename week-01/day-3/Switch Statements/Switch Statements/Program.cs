using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            int UserNumber = int.Parse(Console.ReadLine());

            switch (UserNumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", UserNumber);
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 or 30");
                    break;
            }
            Console.ReadLine();
        }

    }
}
