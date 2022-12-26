﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Zasylogic.Models;

namespace Zasylogic.Controllers
{
    public class FormularioController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
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