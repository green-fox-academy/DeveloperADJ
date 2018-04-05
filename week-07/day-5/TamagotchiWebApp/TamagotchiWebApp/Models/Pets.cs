using System;
using System.Collections.Generic;
using TamagotchiWebApp.Controllers;

namespace TamagotchiWebApp.Models
{
    public class Pets : IPets
    {
        public List<Pet> List = new List<Pet>();

        public void AddToList(Pet tamagotchi)
        {
            List.Add(tamagotchi);
        }

        public List<Pet> GetList()
        {
            return List;
        }
    }
}
