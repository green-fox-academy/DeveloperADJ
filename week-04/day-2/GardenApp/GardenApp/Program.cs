using System;
using System.Drawing;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();

            Flower yellowFlower = new Flower(Color.Yellow);
            Flower blueFlower = new Flower(Color.Blue);
            Tree purpleTree = new Tree(Color.Purple);
            Tree orangeTree = new Tree(Color.Orange);

            garden.AddPlant(yellowFlower);
            garden.AddPlant(blueFlower);
            garden.AddPlant(purpleTree);
            garden.AddPlant(orangeTree);

            garden.ShowGarden();
            Console.WriteLine();
            garden.WaterPlants(40);
            Console.WriteLine();
            garden.ShowGarden();
            Console.WriteLine();
            garden.WaterPlants(70);
            Console.WriteLine();
            garden.ShowGarden();
            Console.ReadLine();
        }
    }
}
