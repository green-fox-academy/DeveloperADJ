using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetSomeone.Models;
using GreetSomeone.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreetSomeone.Controllers
{
    public class HomeController : Controller
    {
        IGreetable greetingRobot;

        public HomeController(IGreetable greetable)
        {
            greetingRobot = greetable;
        }

        [Route("AskName")]
        [HttpGet]
        public IActionResult AskName()
        {
            return View();
        }

        [Route("Greet")]
        [HttpPost]
        public IActionResult Greet(string name)
        {
            return View((object)greetingRobot.Greet(name));
        }
    }
}