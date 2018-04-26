using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class MonkeyController : Controller
    {
         static BankAccounts bankAccounts = new BankAccounts();

        [Route("Simba")]
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Simba()
        {
            return View(bankAccounts);
        }

        [Route("Simba")]
        [HttpPost]
        public IActionResult Simba(int index)
        {
            bankAccounts.animals[index].IncreaseFunds();
            return View(bankAccounts);
        }

        [Route("add")]
        [HttpPost]
        public IActionResult Simba(string name, string balance, string animalType, string imageURL, string isKing, string isBadGuy)
        {
            bool isKingConverted = Convert.ToBoolean(isKing);
            bool isBadGuyConverted = Convert.ToBoolean(isBadGuy);

            bankAccounts.animals.Add(new BankAccount(name, balance, animalType, imageURL, isKingConverted, isBadGuyConverted));
            return View(bankAccounts);
        }
    }
}
