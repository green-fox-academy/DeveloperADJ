using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TamagotchiWebApp.Models;
using TamagotchiWebApp.Services;
using TamagotchiWebApp.ViewModel;

namespace TamagotchiWebApp.Controllers
{
    public class HomeController : Controller
    {
        IPets pets;
        IFoodAndDrinks foodAndDrinks;

        public HomeController(IPets pets, IFoodAndDrinks foodAndDrinks)
        {
            this.pets = pets;
            this.foodAndDrinks = foodAndDrinks;
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            PetEnvironmentViewModel vm = new PetEnvironmentViewModel(pets, foodAndDrinks);
            return View(vm);
        }

        [HttpGet("NutritionStore")]
        public IActionResult NutritionStore(string something)
        {
            PetEnvironmentViewModel vm = new PetEnvironmentViewModel(pets, foodAndDrinks);
            vm.Pets.GetSelectedPet().ImageURL = "http://www.videogamesprites.net/FinalFantasy6/Party/Mog/Mog%20-%20Victory%20(Left).gif";
            return View(vm);
        }

        [HttpPost("Buy")]
        public IActionResult Buy([FromForm]string foodName, [FromForm]string drinkName)
        {
            PetEnvironmentViewModel vm = new PetEnvironmentViewModel(pets, foodAndDrinks);
            vm.FoodAndDrinks.AddToInventory(foodName);
            return RedirectToAction("Pet", new { chosenName = pets.GetSelectedPet().Name});
        }

        [HttpGet("Pet")]
        public IActionResult Pet([FromQuery]string chosenName)
        {
            Pet chosenPet;
            
            chosenPet = pets.GetList().Find(p => p.Name == chosenName);

            if (chosenPet == null)
            { 
                chosenPet = new Pet(chosenName);
                pets.AddToList(chosenPet);
            }

            pets.SetSelectedPet(chosenPet);

            PetEnvironmentViewModel vm = new PetEnvironmentViewModel(pets, foodAndDrinks);
            vm.Pets.GetSelectedPet().ImageURL = "http://www.videogamesprites.net/FinalFantasy6/Party/Mog/Mog%20-%20Walk%20(Front).gif";

            return View(vm);
        }
    }
}