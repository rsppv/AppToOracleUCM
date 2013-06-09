using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModel.Entity;
using DomainModel;
using System.Web.Http;
using System.Net;
using System.Net.Http;

namespace WebUI.Controllers
{
    public class DocController : Controller
    {
        //
        // GET: /Doc/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewMeta()
        {
            dMetaData metadata = new dMetaData();
            return View(metadata.Types);
        }

        public ActionResult Author()
        {
            return View();
        }

        public ActionResult Title()
        {
            return View();
        }

        public ActionResult About(int id)
        {
            try
            {
                DocInformation dInfo = new DocInformation();
                dMetaData metadata = new dMetaData();
                Document document = dInfo.GetDocInfo(id);
                return View(document);
            }
            catch (Exception ex)
            {
                return View("DisplayError", ex);
            }
        }

        
        public FileResult DownloadFile(int id)
        {
            DownloadedFile downloadedFile = new DownloadedFile();
            downloadedFile.Download(id);          
            
            return File(downloadedFile.FileContent,downloadedFile.FileType,downloadedFile.FileName);
        }


        [System.Web.Mvc.HttpGet]
        public ActionResult TitleSearch(String q, bool inTitle = true)
        {
            ViewBag.inTitle = inTitle;
            DocSearch docSearch = new DocSearch();
            if (q == null)
            {
                throw new HttpException(404, "Незаполненное поле поиска. \nРекомендации:/n Попробуйте ввести ключевые слова для поиска");
            }
            try
            {
                String query;
                String sortField;
                if (inTitle)
                {
                    query = "dDocTitle <starts> `" + q.ToUpper() +
                            "` <OR> dDocTitle <starts> `" + q.ToLower() +
                            "`";
                    sortField = "dDocTitle";
                }
                else
                {
                    query = "xDocAuthorsTPU_FIO <starts> `" + q.ToUpper() +
                            "` <OR> xDocAuthorsTPU_FIO <starts> `" + q.ToLower() +
                            "` <OR> xDocCoAuthors <starts> `" + q.ToUpper() +
                            "` <OR> xDocCoAuthors <starts> `" + q.ToLower() +
                            "`";
                    sortField = "xDocAuthorsTPU_FIO";
                }
                docSearch.StartSearch(query, sortField, "ASC");
                return View("SearchResult", docSearch.Results.ToList());
            }
            catch (Exception ex)
            {
                return View("DisplayError", ex);
            }
        }

        public ActionResult Search()
        {
            return View("Search");
        }
        
        public ActionResult FormSearch(String q)
        {
            ViewBag.inTitle = true;
            DocSearch docSearch = new DocSearch();
            if (q == null)
            {
                throw new HttpException(404, "Незаполненное поле поиска. \nРекомендации:/n Попробуйте ввести ключевые слова для поиска");
            }
            try
            {
                ViewBag.q = q;
                docSearch.StartSearch(
                    "xDocAnnotation <substring> `" + q.ToLower() +
                    "` <OR> xDocAnnotation <substring> `" + q[0].ToString().ToUpper() + q.Substring(1).ToLower() +
                    "` <OR> xDocCaption <substring> `" + q.ToLower() +
                    "` <OR> xDocCaption <substring> `" + q[0].ToString().ToUpper() + q.Substring(1).ToLower() +
                    "` <OR> xDocKeyWords <substring> `" + q.ToLower() +
                    "` <OR> xDocKeyWords <substring> `" + q[0].ToString().ToUpper() + q.Substring(1).ToLower() +
                    "`"
                    , "dCreateDate", "DESC");
                return View("QuickSearch", docSearch.Results.ToList());
            }
            catch (Exception ex)
            {
                return View("DisplayError", ex);
            }
        }

    }
}
