﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Entradas";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Comment()
        {
            return View();
        }
    }
}
