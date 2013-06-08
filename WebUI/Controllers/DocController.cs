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

        
        public FileResult DownloadFile(int id, String savePath = "")
        {
            DownloadedFile downloadedFile = new DownloadedFile();
            if (savePath.Equals("")) downloadedFile.Download(id);
            else downloadedFile.Download(id, savePath);
           
            string fName = downloadedFile.DownloadedFileInfo.Title;
            string fType = downloadedFile.DownloadedFileInfo.Format;
            
            return File(downloadedFile.FileContent,fType,fName);
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
                if (inTitle)
                    query = "dDocTitle <starts> `" + q.ToUpper() +
                            "` <OR> dDocTitle <starts> `" + q.ToLower() +
                            "`";
                else 
                    query = "xDocAuthorsTPU_FIO <starts> `" + q.ToUpper() +
                            "` <OR> xDocAuthorsTPU_FIO <starts> `" + q.ToLower() +
                            "` <OR> xDocCoAuthors <starts> `" + q.ToUpper() +
                            "` <OR> xDocCoAuthors <starts> `" + q.ToLower() +
                            "`";
                docSearch.StartSearch(query, "dCreateDate", "DESC");
                return View("SearchResult", docSearch.Results.ToList());
            }
            catch (Exception ex)
            {
                return View("DisplayError", ex);
            }
        }

        public ActionResult Search()
        {
            return View();
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
                    "dDocTitle <substring> `" + q.ToLower() +
                    "` <OR> dDocTitle <substring> `" + q[0].ToString().ToUpper() + q.Substring(1).ToLower() +
                    "` <OR> xDocCaption <substring> `" + q.ToLower() +
                    "` <OR> xDocCaption <substring> `" + q[0].ToString().ToUpper() + q.Substring(1).ToLower() +
                    "` <OR> xDocKeyWords <substring> `" + q.ToLower() +
                    "` <OR> xDocKeyWords <substring> `" + q[0].ToString().ToUpper() + q.Substring(1).ToLower() +
                    "`"
                    , "dCreateDate", "DESC");
                return View("SearchResult", docSearch.Results.ToList());
            }
            catch (Exception ex)
            {
                return View("DisplayError", ex);
            }
        }

    }
}
