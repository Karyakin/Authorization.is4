﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization.Users.Api.Controllers
{
    public class SiteController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetOrders()
        {
            ViewBag.Massage = "Test";
            return View();
        }
    }
}
