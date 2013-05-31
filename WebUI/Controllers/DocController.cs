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

        public ActionResult About(int id)
        {
            DocInformation dInfo = new DocInformation();
            Document document = dInfo.GetDocInfo(id);
            return View(document);
        }

        public ActionResult DownloadFile(int id, String savePath = "")
        {
            DownloadedFile downloadedFile = new DownloadedFile();
            if (savePath.Equals("")) downloadedFile.Download(id);
            else downloadedFile.Download(id, savePath);
            
            return View(downloadedFile.DownloadedFileInfo);
        }

        public ActionResult AdvancedSearch(String query)
        {
            query = "doc";
            query += "`";
            DocSearch docSearch = new DocSearch();
            if (query == null) 
            {
                throw new HttpException(404, "Results not found");
            }
            try
            {
                docSearch.StartSearch("dExtension <substring> `" + query, "dDocName", "DESC", 20);
               
            }
            catch (Exception ex) { Console.Out.Write(ex.StackTrace); }
            return View(docSearch.Results.ToList());
            
          
            
        }

    }
}
