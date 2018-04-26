using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GardenApp
{
    class Tree : Plant
    {
        public Tree(Color color): base(color)
        {
            WaterAbsorption = 0.4;
        }

        public override string ToString()
        {
            if (waterAmount >= 10)
            {
                return $"{color.Name} Tree doesn't need water";
            }
            else
            {
                return $"{color.Name} Tree needs water";
            }
        }
    }
}
