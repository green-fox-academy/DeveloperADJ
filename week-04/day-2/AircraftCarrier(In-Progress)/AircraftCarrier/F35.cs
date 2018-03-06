using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class F35 :  Aircraft
    {
        public F35()
        {
            maxAmmo = 12;
            baseDamage = 50;
            LoadedAmmo = 0;
            Console.WriteLine("Created a F35 (Holds 12 ammo, 50 damage each)");
        }
    }
}
