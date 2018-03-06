using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GardenApp
{
    class Plant
    {
        protected Color color;
        public double waterAmount;
        public double WaterAbsorption { get; protected set; }


        public Plant(Color color)
        {
            this.color = color;
            waterAmount = 0;
        }

    }
}
