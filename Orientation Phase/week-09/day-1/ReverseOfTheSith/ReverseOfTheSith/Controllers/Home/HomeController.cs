using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReverseOfTheSith.Models;

namespace ReverseOfTheSith.Controllers.Home
{
    public class HomeController : Controller
    {
        [HttpPost("/sith")]
        public IActionResult Index([FromBody]YodaSpeaker yodaSpeaker)
        {
            return new JsonResult(new { sith_text = yodaSpeaker.TransformSentence() });
        }
    }
}