﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Общая информация о ресурсе";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Страница описания приложения";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Страница контактов";

            return View();
        }
    }
}
