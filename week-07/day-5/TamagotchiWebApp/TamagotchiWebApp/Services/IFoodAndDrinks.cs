using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TamagotchiWebApp.Models;

namespace TamagotchiWebApp.Services
{
    public interface IFoodAndDrinks
    {
        void AddToList(FoodAndDrink foodAndDrink);
        List<FoodAndDrink> GetList();
    }
}
