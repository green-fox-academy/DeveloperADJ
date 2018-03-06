using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GardenApp
{
    class Flower : Plant
    {
        public Flower(Color color): base(color)
        {
            WaterAbsorption = 0.75;
        }

        public override string ToString()
        {
            if (waterAmount >= 5)
            {
                return $"{color.Name} Flower doesn't need water";
            }
            else
            {
                return $"{color.Name} Flower needs water";
            }
        }
    }
}
