using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Fleet: IComparable<Thing>
    {
        public List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        //public static List<Thing> GetThings()
        //{
        //    return Things;
        //}

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }

        public int CompareTo(Thing other)
        {
            return Things.;
        }
    }
}