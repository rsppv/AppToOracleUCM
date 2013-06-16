using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Entity;
using DomainModel.GetFileRef;
using System.Net;

namespace DomainModel.Entity
{
    public class DownloadedFile
    {
        private GetFile getfile = new GetFile();
        private IdcProperty[] extraProps = new IdcProperty[1];
        
        public Document DownloadedFileInfo { get; set; }
        public byte[] FileContent { get; set; }
        public String FileName { get; set; }
        public String FileType { get; set; }

        /*Конструктор устанавливает настройки
         * сертификата доступа к серверу UCM*/

        public DownloadedFile()
        {
            getfile.Url = Constants.UrlToUCMServices;
            getfile.Credentials = new NetworkCredential(Constants.Login, Constants.Password);
        }

        public void Download(int id)
        {
            GetFileByIDResult Result = getfile.GetFileByID(id, true, "web", extraProps);
            DownloadedFileInfo = new Document(Result.FileInfo[0]);

            FileContent = Result.downloadFile.fileContent;
            FileName = (DownloadedFileInfo.Title.Equals("")) ? "temp" : FileName = DownloadedFileInfo.Title;
            FileName += "." + DownloadedFileInfo.Extension;
            FileType = DownloadedFileInfo.Format;
        }

    }
}
