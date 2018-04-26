using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            bool val1 = true;
            bool val2 = true;
            bool val3 = true;

            bool result1 = val1;
            bool result2 = val2;
            bool result3 = !(val3 && val2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
