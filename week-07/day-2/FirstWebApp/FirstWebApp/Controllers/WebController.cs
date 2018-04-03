using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        // GET: /<controller>/
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting($"{name}");

            return View(greeting);
        }
    }
}
