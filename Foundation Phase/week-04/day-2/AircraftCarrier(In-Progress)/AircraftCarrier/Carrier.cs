using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class Carrier
    {
        List<F16> F16s = new List<F16>();
        List<F35> F35s = new List<F35>();

        int totalDamage;


        public int ammoStorage;
        int health;

        public Carrier(int health, int ammoStorage)
        {
            this.health = health;
            this.ammoStorage = ammoStorage;
        }

        public void AddAircraft(string aircraftType)
        {
            if (aircraftType == "F16")
            {
                F16s.Add(new F16());
            }
            else if (aircraftType == "F35")
            {
                F35s.Add(new F35());
            }
        }

        public int Fill()
        {
            try
            {
                if (ammoStorage == 0)
                    throw new Exception("Cannot Refill Aircrafts: Storage is empty");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            if (ammoStorage > 0)
            {
                if (F16s.Count > 0)
                {
                    for (int i = 0; i < F16s.Count; i++)
                    {
                        if (ammoStorage > 0)
                        {
                            ammoStorage = F16s[i].Refill(ammoStorage);
                        }
                    }
                }

                if (F35s.Count > 0)
                {
                    for (int i = 0; i < F35s.Count; i++)
                    {
                        if (ammoStorage > 0)
                        {
                            ammoStorage = F35s[i].Refill(ammoStorage);
                        }
                    }
                }
            }

            Console.WriteLine("Refilling all aircrafts..");

            return ammoStorage;
        }

        public int CountTotalDamage()
        {
            totalDamage = 0;
            for (int i = 0; i < F16s.Count; i++)
            {
                totalDamage += F16s[i].baseDamage * F16s[i].loadedAmmo;
            }

            for (int i = 0; i < F35s.Count; i++)
            {
                totalDamage += F35s[i].baseDamage * F35s[i].loadedAmmo;
            }

            return totalDamage;
        }


        public string GetStatus()
        {
            int totalDamage = CountTotalDamage();

            return $"HP: {health}, Aircraft count: {F16s.Count + F35s.Count}, Ammo Storage: {ammoStorage}, Total damage: {totalDamage}";
        }

    }
}
