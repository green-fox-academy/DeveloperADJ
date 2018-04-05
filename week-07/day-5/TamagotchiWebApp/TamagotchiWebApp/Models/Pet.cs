using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TamagotchiWebApp.Services;

namespace TamagotchiWebApp.Models
{
    public class Pet : IPettable, IEquatable<Pet>
    {
        public int ID { get; set; }
        public int Food { get; set; }
        public string Name { get; set; } = "Mr. Fox";
        public string ImageURL { get; set; } = "http://www.gifmania.co.uk/Objects-Animated-Gifs/Animated-Toys/Tamagotchis/Tamagotchi-Poo-80574.gif";
        public List<string> Tricks { get; set; } = new List<string>
        {
            "Cook",
            "Kung Fu",
            "Eating a lot",
            "Drinking palinka"
        };

        public Pet(string name)
        {
            Name = name;
            ID++;
        }

        public bool Equals(Pet other)
        {
            return Name == other.Name;
        }
    }
}
