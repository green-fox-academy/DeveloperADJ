using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoList_DI.Services;

namespace TodoList_DI.Controllers
{
    public class HomeController : Controller
    {
        ICreatable TodoList;

        public HomeController(ICreatable todoList)
        {
            TodoList = todoList;
        }

        [Route("Todo")]
        [HttpGet]
        public IActionResult Todo()
        {
            TodoList.Order();
            return View(TodoList);
        }

        [Route("Add")]
        [HttpPost]
        public IActionResult Todo(string taskName)
        {
            TodoList.Create(taskName);
            return View(TodoList);
        }

        [Route("Delete")]
        [HttpPost]
        public IActionResult Todo(int taskIndex)
        {
            TodoList.Delete(taskIndex);
            return View(TodoList);
        }
    }
}