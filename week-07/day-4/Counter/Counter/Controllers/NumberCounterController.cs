using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Counter.Models;
using Microsoft.AspNetCore.Mvc;

namespace Counter.Controllers
{
    public class NumberCounterController : Controller
    {
        static NumberCounter numberCounter = new NumberCounter();

        [Route("Counter")]
        [HttpGet]
        public IActionResult Counter()
        {
            return View(numberCounter);
        }

        [Route("Increased")]
        [HttpPost]
        public IActionResult Increase(int count)
        {
            numberCounter.IncreaseNumber();
            return RedirectToAction("Counter");
        }
    }
}