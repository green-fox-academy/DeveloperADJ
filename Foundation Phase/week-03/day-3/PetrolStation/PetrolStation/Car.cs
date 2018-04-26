using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    class Car
    {
        public int gasAmount;
        public int capacity;

        public Car(int gasAmount = 0, int capacity = 100)
        {
            this.gasAmount = gasAmount;
            this.capacity = capacity;
        }
    }
}
