using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    class Station
    {
        int gasAmount;

        public Station(int gasAmount = 10000)
        {
            this.gasAmount = gasAmount;
        }

        public void Refill(Car car)
        {
            gasAmount -= car.capacity;
            Console.WriteLine($"Refilled the car by: {car.capacity}, the amount of gas left at the station is: {gasAmount}.");
        }
    }
}
