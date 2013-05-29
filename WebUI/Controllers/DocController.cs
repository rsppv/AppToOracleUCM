using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModel.Entity;
using DomainModel;

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

        public ActionResult DownloadFile(int id, String savePath)
        {
            DownloadedFile downloadedFile = new DownloadedFile();
            downloadedFile.Download(id, savePath); 
            return View(downloadedFile.DownloadedFileInfo);
        }

    }
}
