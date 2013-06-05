using DomainModel.MetaDataRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entity
{
    public class dMetaData
    {
        private MetaData service = new MetaData();
        private IdcProperty[] extraProps = new IdcProperty[1];
        
        public DocTypes Types {get; set; }
        public DocMetaFields MetaFields { get; set; }

        /* Конструктор. Устанавливает настройки сертификата
         * доступа к UCM серверу.
         */
        public dMetaData()
        {
            SetDomainPath(Constants.UrlToUCMServices);
            SetSecurity(Constants.Login, Constants.Password);
        }

        /* Устанавливает домен для обращения к серверу веб-службы.*/

        private void SetDomainPath(string url)
        {
            service.Url = url;
        }


        /* Устанавливает логин и парооль сертификата доступа к серверу веб-службы.*/

        private void SetSecurity(string log, string pwd)
        {
            service.Credentials = new NetworkCredential(log, pwd);
        }


        public void GetMetaData()
        {
            DocMetaDataResult result = service.DocMetaData(0, true, extraProps);
           
            if (result == null)
            {
                throw new Exception("Ваш запрос не был обработан сервером. Попробуйте позже");
            }
            if (result.StatusInfo.statusCode < 0)
            {
                throw new Exception(result.StatusInfo.statusMessage);
            }

            if (result.DocMetaFields == null)
            {
                // This should never happen.
                throw new Exception("Запрашиваемая информация отсутсвует");
            }

            Types = result.DocTypes[0];
            MetaFields = result.DocMetaFields[0];
            
        }
    }
}
