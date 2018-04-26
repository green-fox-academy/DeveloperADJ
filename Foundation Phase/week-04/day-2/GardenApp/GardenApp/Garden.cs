using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Garden
    {
        static List<Plant> plants = new List<Plant>();

        public void AddPlant(Flower flower)
        {
            plants.Add(flower);
        }

        public void AddPlant(Tree tree)
        {
            plants.Add(tree);
        }

        public void ShowGarden()
        {
            if (plants.Count > 0)
            {
                for (int i = 0; i < plants.Count; i++)
                {
                    Console.WriteLine($"The {plants[i]}");
                }
            }
        }

        public void WaterPlants(double amountOfWater)
        {
            double waterPerPlant = amountOfWater / plants.Count;

            Console.WriteLine("Watering with " + amountOfWater);

            if (plants.Count > 0)
            {
                for (int i = 0; i < plants.Count; i++)
                {
                    plants[i].waterAmount += waterPerPlant * plants[i].WaterAbsorption;
                }
            }
        }
    }
}
