using System;

namespace Pirate
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate.DrinkSomeRum(3);
            Pirate.HowsItGoingMate();
            Pirate.DrinkSomeRum(8);
            Pirate.HowsItGoingMate();

            Pirate.Die();
            Pirate.DrinkSomeRum();
            Pirate.HowsItGoingMate();

            Console.ReadLine();
        }
    }
}
