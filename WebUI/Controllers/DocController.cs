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

        public RedirectResult Index()
        {
            return RedirectPermanent("/Home/Index");
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




    }
}
