﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class MonkeyController : Controller
    {
        [Route("Simba")]
        // GET: /<controller>/
        public IActionResult Simba()
        {
            var bankAccounts = new BankAccounts();
            return View(bankAccounts);
        }
    }
}