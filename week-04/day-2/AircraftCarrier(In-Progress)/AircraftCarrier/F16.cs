using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class F16 :  Aircraft
    {
        public F16()
        {
            maxAmmo = 8;
            baseDamage = 30;
            LoadedAmmo = 0;
            Console.WriteLine("Created a F16, (holds 8 ammo 30 damage each)");

        }
    }
}
