using Counter.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Models
{
    public class NumberCounter : ICountable
    {
        public int Number { get; private set; }

        public void IncreaseNumber()
        {
            Number++;
        }
    }
}
