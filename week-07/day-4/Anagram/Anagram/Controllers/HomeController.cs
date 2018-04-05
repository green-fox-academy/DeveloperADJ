using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anagram.Models;
using Anagram.Services;
using Microsoft.AspNetCore.Mvc;

namespace Anagram.Controllers
{
    public class HomeController : Controller
    {
        IAnagramCheckable anagramChecker;

        public HomeController(IAnagramCheckable anagramChecker)
        {
            this.anagramChecker = anagramChecker;
        }

        [Route("AskForAnagram")]
        public IActionResult AskForAnagram()
        {
            return View();
        }

        [Route("CheckAnagram")]
        public IActionResult CheckAnagram(string firstWord, string secondWord)
        {
            return View((object)anagramChecker.CheckWordForAnagram(firstWord, secondWord));
        }
    }
}