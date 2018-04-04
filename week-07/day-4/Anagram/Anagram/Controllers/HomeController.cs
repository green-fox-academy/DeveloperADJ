using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anagram.Models;
using Microsoft.AspNetCore.Mvc;

namespace Anagram.Controllers
{
    public class HomeController : Controller
    {
        AnagramChecker anagramChecker = new AnagramChecker();

        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Index")]
        public IActionResult Index()
        {

            return View();
        }
    }
}