using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DocInfoRef;
using System.Net;
using DomainModel.Entity;


namespace DomainModel.Entity
{
    public class DocInformation 
    {
        
        private DocInfo docinfo = new DocInfo();
        private IdcProperty[] extraProps;
     
       
        /* Конструктор. Устанавливает настройки сертификата
         * доступа к UCM серверу.
         */
        public DocInformation()
        {
           
            SetDomainPath(Constants.UrlToUCMServices);
            SetSecurity(Constants.Login, Constants.Password);
        }


        /* Устанавливает домен для обращения к серверу веб-службы.*/

        private void SetDomainPath(string url)
        {
            docinfo.Url = url;
        }


        /* Устанавливает логин и парооль сертификата доступа к серверу веб-службы.*/

        private void SetSecurity(string log, string pwd)
        {
            docinfo.Credentials = new NetworkCredential(log, pwd);
        }


        public Document GetDocInfo(int id)
        {
            DocInfoByIDResult docInfoByIDResult = docinfo.DocInfoByID(id, true, extraProps);
            
            
            if (docInfoByIDResult == null)
            {
                throw new Exception("Ваш запрос не был обработан сервером. Попробуйте позже");
            }
            if (docInfoByIDResult.StatusInfo.statusCode < 0)
            {
                throw new Exception(docInfoByIDResult.StatusInfo.statusMessage);
            }

            if (docInfoByIDResult.ContentInfo == null)
            {
                // This should never happen.
                throw new Exception("Запрашиваемая информация отсутсвует");
            }
            Document document = new Document(docInfoByIDResult.ContentInfo[0]);
            return document;
        }

    }
}
