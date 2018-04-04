using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetSomeone.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreetSomeone.Controllers
{
    public class HomeController : Controller
    {
        static GreetingRobot greetingRobot = new GreetingRobot();

        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(greetingRobot);
        }

        [Route("Greet")]
        [HttpPost]
        public IActionResult Greeter(string name)
        {
            greetingRobot.Message = "Welcome ";
            greetingRobot.Name = name;
            return View(greetingRobot);
        }
    }
}