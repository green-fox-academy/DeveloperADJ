using Frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers.Home
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/Doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return new JsonResult(new
                {
                    error = "Please provide an input!"
                });
            }
            else
            {
                return new JsonResult(new
                {
                    received = input,
                    result = input * 2
                });
            }
        }

        [HttpGet("/Greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name is null)
            {
                return new JsonResult(new
                {
                    error = "Please provide a name!"
                });
            }
            else if (title is null)
            {
                return new JsonResult(new
                {
                    error = "Please provide a title!"
                });
            }
            else
            {
                return new JsonResult(new
                {
                    welcome_message = $"Oh, hi there {name}, my dear {title}!"
                });
            }
        }


        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            return new JsonResult(new
            {
                appended = appendable + "a"
            });
        }

        [HttpGet("/appenda")]
        public IActionResult AppendA()
        {
            return StatusCode(404);
        }

        [HttpPost("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody]DoUntil doUntil)
        {
            if (doUntil.Until == null)
            {
                return new JsonResult(new { error = "Please provide a number!" });
            }
            else
            {
                if (what == "sum")
                {
                    return new JsonResult(new { result = doUntil.Sum() });
                }
                else if (what == "factor")
                {
                    return new JsonResult(new { result = doUntil.Factor() });
                }
            }
            return new JsonResult(new { error = "Please provide a number!" });

        }
    }
}