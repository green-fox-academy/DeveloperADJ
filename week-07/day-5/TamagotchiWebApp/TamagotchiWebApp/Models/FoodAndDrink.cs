using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TamagotchiWebApp.Models
{
    public class FoodAndDrink
    {
        public string Name { get; set; }
        public string Taste { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }

        public FoodAndDrink(string name, string taste, string imageURL, double price)
        {
            Name = name;
            Taste = taste;
            ImageURL = imageURL;
            Price = price;
        }
    }
}
