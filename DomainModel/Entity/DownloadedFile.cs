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
        private IdcProperty[] extraProps;

        public Document DownloadedFileInfo { get; set; }

        /*Конструктор устанавливает настройки
         * сертификата доступа к серверу UCM*/

        public DownloadedFile()
        {
            getfile.Url = Constants.UrlToUCMServices;
            getfile.Credentials = new NetworkCredential(Constants.Login, Constants.Password);
        }

        public void Download(int id, String savePath)
        {
            GetFileByIDResult getFileResult = getfile.GetFileByID(id, true, "web", extraProps);
            IdcFile idcFile = getFileResult.downloadFile;
            DownloadedFileInfo = new Document(getFileResult.FileInfo[0]);

            String fileName;
            fileName = ( idcFile.fileName.Equals("") ) ? "temp" : fileName = idcFile.fileName;

            String filePath = savePath + @"\" + fileName;
            byte[] fileContent = idcFile.fileContent;
            
            System.IO.FileStream fstream = null;
            try
            {
                fstream = new System.IO.FileStream(filePath, System.IO.FileMode.Create);
                fstream.Write(fileContent, 0, fileContent.Length);
            }
            finally
            {
                if (fstream != null)
                {
                    fstream.Close();
                }
            }

        }

    }
}
