using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class DoUntil
    {
        public int? Until { get; set; }

        public int Sum()
        {
            int summedNumber = 0;

            for (int i = 0; i <= Until; i++)
            {
                summedNumber += i;
            }
            return summedNumber;
        }

        public int Factor()
        {
            int factoredNumber = 1;

            for (int i = 1; i <= Until; i++)
            {
                factoredNumber *= i;
            }

            return factoredNumber;
        }
    }
}
