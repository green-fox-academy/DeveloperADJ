using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Models
{
    public class NumberCounter
    {
        public int Number { get; private set; }

        public NumberCounter(int number = 0)
        {
            Number = number;
        }

        public void IncreaseNumber()
        {
            Number++;
        }
    }
}
