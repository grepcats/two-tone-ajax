﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwoToneAjax.Models;

namespace TwoToneAjax.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HelloAjax()
        {
            return Content("Henlo from the supernintendo Chalmers", "text/plain");
        }

        public IActionResult Sum(int firstNumber, int secondNumber)
        {
            return Content((firstNumber + secondNumber).ToString(), "text/plain");
        }

        public IActionResult DisplayObject()
        {
            Destination destination = new Destination("Tokyo", "Japan", 1);
            return Json(destination);
        }

        public IActionResult DisplayViewWithAjax()
        {
            return View();
        }
    }
}
