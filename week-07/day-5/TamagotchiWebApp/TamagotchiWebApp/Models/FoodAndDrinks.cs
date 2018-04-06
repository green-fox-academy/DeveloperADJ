﻿using System.Collections.Generic;
using TamagotchiWebApp.Services;

namespace TamagotchiWebApp.Models
{
    public class FoodAndDrinks : IFoodAndDrinks
    {
        public List<FoodAndDrink> List = new List<FoodAndDrink>
        {
            new FoodAndDrink("Potato", "sweet", "", 100),
            new FoodAndDrink("Gyros Sandwich", "salty", "", 1000),
            new FoodAndDrink("Langos", "salty", "", 700)
        };

        public List<string> Inventory = new List<string>();

         public void AddToInventory(string foodAndDrink)
        {
            Inventory.Add(foodAndDrink);
        }

        public List<string> GetInventory()
        {
            return Inventory;
        }

        public void AddToList(FoodAndDrink foodAndDrink)
        {
            List.Add(foodAndDrink);
        }

        public List<FoodAndDrink> GetList()
        {
            return List;
        }
    }
}
