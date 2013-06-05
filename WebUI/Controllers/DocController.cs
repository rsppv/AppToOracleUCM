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

        public ActionResult About(int id)
        {
            DocInformation dInfo = new DocInformation();
            dMetaData metadata = new dMetaData();
            Document document = dInfo.GetDocInfo(id);
            return View(document);
        }

        public ActionResult DownloadFile(int id, String savePath = "")
        {
            DownloadedFile downloadedFile = new DownloadedFile();
            if (savePath.Equals("")) downloadedFile.Download(id);
            else downloadedFile.Download(id, savePath);
            
            return View("About",downloadedFile.DownloadedFileInfo);
        }

        [System.Web.Mvc.HttpGet]
        public ActionResult LetterSearch(String q)
        {
            //query = "T";
            DocSearch docSearch = new DocSearch();
            if (q == null)
            {
                throw new HttpException(404, "Results not found");
            }
            try
            {
                docSearch.StartSearch("dDocTitle <starts> `" + q.ToUpper() + 
                    "` <OR> dDocTitle <starts> `" + q.ToLower() + "`", "dCreateDate", "DESC");
                return View(docSearch.Results.ToList());
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
            DocSearch docSearch = new DocSearch();
            if (q == null)
            {
                throw new HttpException(404, "Results not found");
            }
            try
            {
                ViewBag.q = q;
                docSearch.StartSearch("dDocTitle <substring> `" + q.ToLower() +
                    "` <OR> dDocTitle <substring> `" + q[0].ToString().ToUpper() + q.Substring(1).ToLower() + "`"
                    , "dCreateDate", "DESC");
                return View("LetterSearch", docSearch.Results.ToList());
            }
            catch (Exception ex)
            {
                return View("DisplayError", ex);
            }
        }

    }
}
