using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Counter.Models;
using Counter.Services;
using Microsoft.AspNetCore.Mvc;

namespace Counter.Controllers
{
    public class NumberCounterController : Controller
    {
        ICountable numberCounter;

        public NumberCounterController(ICountable countable)
        {
            numberCounter = countable;
        }

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