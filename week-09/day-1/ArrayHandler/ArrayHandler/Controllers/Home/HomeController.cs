using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArrayHandler.Models;
using ArrayHandler.Repositories;
using LogEntries.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArrayHandler.Controllers.Home
{
    public class HomeController : Controller
    {
        int i = 0;
        ILogRepository logRepository;

        public HomeController(ILogRepository logRepository)
        {
            this.logRepository = logRepository;
        }

        [HttpPost("arrays")]
        public IActionResult Index([FromBody]Handler handler)
        {
            logRepository.Create("arrays", $"{i++}");
            return handler.ProcessArray();
        }

        [HttpGet("log")]
        public IActionResult Log()
        {
            return new JsonResult(new { entries = logRepository.Read(), entry_count = logRepository.Read().Count() });
        }
    }
}