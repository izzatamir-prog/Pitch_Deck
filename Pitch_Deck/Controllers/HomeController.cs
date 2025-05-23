﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pitch_Deck.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pitch_Deck.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Submit(Contact model)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation("Form submitted: Name={Name}, Email={Email}, Phone={Phone}, Message={Message}",
                    model.Name, model.Email, model.PhoneNo, model.Message);

                
            }

            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
