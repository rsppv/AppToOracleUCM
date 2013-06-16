using DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        public RedirectResult Index()
        {
            return RedirectPermanent("/Search/Simple");
        }

        [System.Web.Mvc.HttpGet]
        public ActionResult Simple()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Simple(String q)
        {
            DocSearch docSearch = new DocSearch();
            ViewBag.q = q;
             
            try
            {
                docSearch.SimpleSearch(q);
                ViewBag.ResultCount = docSearch.CountResults;
                return View("Results", docSearch.Results.ToList());
            }
            catch (Exception ex)
            {
                ViewBag.ExMsg = "Результаты поиска";
                return View("DisplayError", ex);
            }
        }



        [System.Web.Mvc.HttpGet]
        public ActionResult FullText()
        {
            return View();
        } 

        
        [System.Web.Mvc.HttpPost]
        public ActionResult FullText(String q)
        {
            DocSearch docSearch = new DocSearch();
            ViewBag.q = q;

            try
            {
                docSearch.FullTextSearch(q);
                ViewBag.ResultCount = docSearch.CountResults;
                return View("Results", docSearch.Results.ToList());
            }
            catch (Exception ex)
            {
                ViewBag.ExMsg = "Результаты поиска";
                return View("DisplayError", ex);
            }
        }


        public ActionResult CatalogByAuthor()
        {
            return View();
        }


        public ActionResult CatalogByAuthorResponse(String letter)
        {
            DocSearch docSearch = new DocSearch();
            ViewBag.q = letter;
            try
            {
                docSearch.SearchByLetter(letter, false);
                ViewBag.ResultCount = docSearch.CountResults;
                return View("Results", docSearch.Results.ToList());
            }
            catch (Exception ex)
            {
                ViewBag.ExMsg = "Результаты поиска";
                return View("DisplayError", ex);
            }
        }


        public ActionResult CatalogByTitle()
        {
            return View();
        }


        public ActionResult CatalogByTitleResponse(String letter)
        {
            DocSearch docSearch = new DocSearch();
            ViewBag.q = letter;
            try
            {
                docSearch.SearchByLetter(letter, true);
                ViewBag.ResultCount = docSearch.CountResults;
                return View("Results", docSearch.Results.ToList());
            }
            catch (Exception ex)
            {
                ViewBag.ExMsg = "Результаты поиска";
                return View("DisplayError", ex);
            }
        } 

    }
}
