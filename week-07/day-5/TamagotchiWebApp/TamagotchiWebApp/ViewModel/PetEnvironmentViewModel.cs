using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TamagotchiWebApp.Controllers;
using TamagotchiWebApp.Services;

namespace TamagotchiWebApp.ViewModel
{
    public class PetEnvironmentViewModel
    {
        public IPets Pets { get; set; }
        public IFoodAndDrinks FoodAndDrinks { get; set; }

        public PetEnvironmentViewModel(IPets pets, IFoodAndDrinks foodAndDrinks)
        {
            this.Pets = pets;
            this.FoodAndDrinks = foodAndDrinks;
        }
    }
}
