﻿//using Guarda.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Guarda.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}