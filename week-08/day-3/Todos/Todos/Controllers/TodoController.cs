using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Todos.Models;
using Todos.Services;

namespace Todos.Controllers
{
    [Route("Todo")]
    public class TodoController : Controller
    {
        IRepository repository;

        public TodoController(IRepository repository) 
        {
            this.repository = repository;
        }

        [HttpGet("List")]
        public IActionResult List()
        {
            return View(repository.Read());
        }

        [HttpGet("Add")]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost("Create")]
        public IActionResult Create(string title)
        {
            repository.Create(new Todo
            {
                Title = title
            });

            return RedirectToAction("List");
        }

        [HttpGet("Edit")]
        public IActionResult Edit()
        {

            return View();
        }

        [HttpGet("Delete")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);

            return RedirectToAction("List");
        }
    }
}