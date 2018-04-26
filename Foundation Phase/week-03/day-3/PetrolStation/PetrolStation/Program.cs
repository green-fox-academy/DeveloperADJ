using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Petrol Station
            Create Station and Car classes
            Station
                GasAmount
                Refill(car) -> decreases the gasAmount by the capacity of the car and increases the cars gasAmount
            Car
                GasAmount
                Capacity
            create constructor for Car where:
            initialize gasAmount -> 0
            initialize capacity -> 100*/

            Station shell = new Station();
            Car Jeep = new Car();

            shell.Refill(Jeep);

            Console.ReadLine();
        }
    }
}
