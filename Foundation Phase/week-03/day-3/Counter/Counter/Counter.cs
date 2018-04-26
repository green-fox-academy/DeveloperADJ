using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    class Counter
    {
        int counter;

        public Counter(int counter = 0)
        {
            this.counter = counter;
        }

        public void Add(int value = 1)
        {
            counter += value;
            Console.WriteLine($"Added {value} to the counter, the counter is now {counter}");
        }

        public string Get()
        {
            Console.WriteLine($"Returning a value of {counter} as a string");
            return Convert.ToString(counter);
        }

        public void Reset()
        {
            counter = 0;
            Console.WriteLine($"Reset the counter to {counter}");
        }
    }
}
