using System;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Farm
            Reuse your Animal class
            Create a Farm class
            it has list of Animals
            it has slots which defines the number of free places for animals
            breed() -> creates a new animal if there's place for it
            slaughter() -> removes the least hungry animal*/

            Farm myFarm = new Farm();

            Animal pig = new Animal(70, 80);
            myFarm.animals.Add(pig);

            Animal cow = new Animal();
            myFarm.animals.Add(cow);

            Animal chicken = new Animal(60, 50);
            myFarm.animals.Add(chicken);

            myFarm.Breed(30);
            myFarm.Breed(20);
            myFarm.Breed(10);
            myFarm.Breed(3);
            myFarm.Breed(1);
            myFarm.Breed(2);
            myFarm.Breed(50);
            myFarm.Breed(0);
            myFarm.Breed(8);
            myFarm.Breed(70);

            myFarm.Slaughter();
            myFarm.Slaughter();
            myFarm.Slaughter();
            myFarm.Slaughter();
            myFarm.Slaughter();
            myFarm.Slaughter();
            myFarm.Slaughter();
            myFarm.Slaughter();
            myFarm.Slaughter();
            myFarm.Slaughter();
            myFarm.Slaughter();
            myFarm.Slaughter();
            myFarm.Slaughter();
            myFarm.Slaughter();
            myFarm.Slaughter();


            Console.Read();



        }
    }
}
