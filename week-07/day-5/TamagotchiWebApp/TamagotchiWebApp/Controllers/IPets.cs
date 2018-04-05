using System.Collections.Generic;
using TamagotchiWebApp.Models;

namespace TamagotchiWebApp.Controllers
{
    public interface IPets
    {
        void AddToList(Pet name);
        List<Pet> GetList();
    }
}