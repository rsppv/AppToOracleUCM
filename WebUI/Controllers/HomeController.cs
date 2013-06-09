using System;
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
            ViewBag.Message = "Добро пожаловать";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Каталог документов";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Контактная информация";

            return View();
        }
    }
}
