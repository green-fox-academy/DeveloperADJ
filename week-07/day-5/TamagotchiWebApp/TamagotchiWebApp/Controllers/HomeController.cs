using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TamagotchiWebApp.Models;

namespace TamagotchiWebApp.Controllers
{
    public class HomeController : Controller
    {
        IPets pets;

        public HomeController(IPets pets)
        {
            this.pets = pets;
        }

        [Route("Login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View(pets);
        }

        [Route("Pet")]
        [HttpGet]
        public IActionResult Pet(string chosenName)
        {
            Pet chosenPet;

            if (pets.GetList().Any(p => p.Name == chosenName))
            {
                chosenPet = pets.GetList().Find(p => p.Name == chosenName);
            }
            else
            {
                chosenPet = new Pet(chosenName);
                pets.AddToList(chosenPet);
            }

            return View(chosenPet);
        }
    }
}