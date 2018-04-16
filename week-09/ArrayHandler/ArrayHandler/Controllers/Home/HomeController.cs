using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArrayHandler.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArrayHandler.Controllers.Home
{
    public class HomeController : Controller
    {
        [HttpPost("arrays")]
        public IActionResult Index([FromBody]Handler handler)
        {
            return handler.ProcessArray();
        }
    }
}