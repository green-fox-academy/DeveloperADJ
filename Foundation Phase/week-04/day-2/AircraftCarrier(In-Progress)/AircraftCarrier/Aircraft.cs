using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class Aircraft
    {
        public int maxAmmo;
        public int baseDamage;

        public int loadedAmmo;

        public Aircraft()
        {
        }

        protected int LoadedAmmo
        {
            set
            {
                if (value > maxAmmo)
                {
                    loadedAmmo = maxAmmo;
                }
                else
                {
                    loadedAmmo = value;
                }
            }
            get
            {
                return loadedAmmo;
            }
        }

        public int Fight()
        {
            int totalDamage = LoadedAmmo * baseDamage;
            LoadedAmmo = 0;

            return totalDamage;
        }

        public int Refill(int ammoStorage)
        {   
            ammoStorage -= (maxAmmo - LoadedAmmo);
            LoadedAmmo += ammoStorage;

            return ammoStorage;
        }

        public string GetTypeName()
        {
            return this.GetType().Name;
        }

        public string GetStatus()
        {
            return $"Type {GetTypeName()}, Ammo: {loadedAmmo}, Base Damage: {baseDamage}, All Damage: {Fight()}";
        }

    }
}
