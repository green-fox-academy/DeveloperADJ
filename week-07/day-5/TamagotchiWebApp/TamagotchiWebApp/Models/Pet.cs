using System;
using System.Collections.Generic;
using TamagotchiWebApp.Services;

namespace TamagotchiWebApp.Models
{
    public class Pet : IPettable, IEquatable<Pet>
    {
        public int ID { get; set; }
        public string Name { get; set; } = "Mr. Fox";
        public string ImageURL { get; set; } = "http://www.videogamesprites.net/FinalFantasy6/Party/Mog/Mog%20-%20Walk%20(Front).gif";
        public List<string> Tricks { get; set; }
        public double Money { get; set; } = 10000;

        public List<string> Inventory = new List<string>();


        public void AddToInventory(string foodAndDrink)
        {
            Inventory.Add(foodAndDrink);
        }

        public List<string> GetInventory()
        {
            return Inventory;
        }

        public Pet(string name)
        {
            Tricks = new List<string>
        {
            "Wave",
            "Fly"
        };
            Name = name;
            ID++;
        }
        public Pet(string name, List<string> tricks)
        {
            Tricks = tricks;
            Name = name;
            ID++;
        }

        public bool Equals(Pet other)
        {
            return Name == other.Name;
        }

        public double Purchase()
        {
            return Money -= 100;
        }
    }
}
