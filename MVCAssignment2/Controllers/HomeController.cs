﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int amount)
        {
            ViewBag.amount = amount;
            return View();
        }
    }
}