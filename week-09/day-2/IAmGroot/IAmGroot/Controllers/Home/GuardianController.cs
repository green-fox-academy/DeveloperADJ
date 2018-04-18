using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using IAmGroot.Models;
using Microsoft.AspNetCore.Mvc;

namespace IAmGroot.Controllers.Home
{
    public class GuardianController : Controller
    {
        [HttpGet("groot")]
        public IActionResult Index(string message)
        {
            if (message == null)
            {
                //return new NotFoundObjectResult(new JsonResult(new { error = "I am Groot!" }));
                return new JsonResult(new { error = "I am Groot!" });
            }
            else
            {
                return new JsonResult(new { received = message, translated = "I am Groot!" });
            }
        }

        [HttpGet("yondu")]
        public IActionResult Yondu(double? distance, double? time)
        {
            if (distance != null && time != null)
            {
                return new JsonResult(new { Distance = distance, Time = time, Speed = distance / time });
            }
            else
            {
                return StatusCode(404);
            }
        }


        [HttpGet("rocket")]
        public IActionResult Rocket()
        {
            return new JsonResult(new Rocket());
        }

        [HttpGet("rocket/refill")]
        public IActionResult RocketRefill(double? caliber, double? amount)
        {
            if (caliber != null && amount != null)
            {
                return new JsonResult(new
                {
                    Received = caliber,
                    Amount = amount,
                    Shipstatus = $"{(amount / 12500) * 100}%",
                    ready = false
                });
            }
            else
            {
                return StatusCode(404);
            }
        }
    }
}