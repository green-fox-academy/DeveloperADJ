using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    class Farm
    {
        public List<Animal> animals = new List<Animal>();
        public int slots;
        
        public Farm()
        {
           this.slots = animals.Capacity = 10;
        }

        public void Breed(int hungerValue)
        {
            if (slots > animals.Count)
            {
                animals.Add(new Animal(hungerValue));
                Console.WriteLine($"You bred an animal! The amount of animals in your farm is now {animals.Count}.");
            }
            else
            {
                Console.WriteLine("Your farm is full, you can't breed anymore animals.");
            }

            
        }

        public void Slaughter()
        {
            int lowestHungerValue = 1000;
            int animalToBeSlaughtered = 0;

            if (animals.Count > 0)
            {
                for (int i = 0; i < animals.Count; i++)
                {
                    if (lowestHungerValue > animals[i].hungerValue)
                    {
                        lowestHungerValue = animals[i].hungerValue;
                        animalToBeSlaughtered = i;
                    }
                }
                Console.Write($"You slaughtered the least hungry animal (hungerValue: {lowestHungerValue}) ");
                animals.RemoveAt(animalToBeSlaughtered);
                Console.WriteLine($"the amount of animals at your farm is { animals.Count}");
            }
            else
            {
                Console.WriteLine("Your farm is empty, there are no animals to slaughter.");
            }
        }
    }
}
