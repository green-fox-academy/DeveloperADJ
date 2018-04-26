using System;
using System.Collections.Generic;
using System.Text;

namespace SharpieSet
{
    class SharpieSet
    {

        public static List<Sharpie> Sharpies = new List<Sharpie>();
        public static List<Sharpie> UsableSharpies = new List<Sharpie>();

        public static void AddSharpieToList(Sharpie sharpie)
        {
            Sharpies.Add(sharpie);
        }

        public static int CountUsable()
        {
            int count = 0;

            foreach (var sharpie in Sharpies)
            {
                if (sharpie.inkAmount > 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"There are {count} usable sharpies left.");
            return count;
        }

        public static void RemoveTrash()
        {
            int amountRemoved = 0;
            for (int i = 0; i < Sharpies.Count; i++)
            {
                
                if (Sharpies[i].inkAmount <= 0)
                {
                    amountRemoved++;
                    Sharpies.RemoveAt(i);
                }
            }

            Console.WriteLine($"Removed {amountRemoved} from the set.");
        }

    }
}
