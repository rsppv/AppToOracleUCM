using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.SearchRef;
using DomainModel.Entity;
using System.Net;

namespace DomainModel.Entity
{
    public class DocSearch
    {
        private Search searchService = new Search();
        private IdcProperty[] extraProps = new IdcProperty[1];
        private IQueryable<Document> results;

        public IQueryable<Document> Results { get { return results;} }

        public int CountResults { get; set; } //Найденные документы, соответствующие запросу
        public int CountRecords { get; set; } //Количество отображаемых записей
        

        public DocSearch()
        {
            searchService.Url = Constants.UrlToUCMServices;
            searchService.Credentials = new NetworkCredential(Constants.Login, Constants.Password);
        }
       

        
        public void SearchByLetter(String q, bool inTitle)
        {
            String request;
            String sortField;
            int resultCount = 100; // Количество выдаваемых результатов

            /* Формируем строку запросу к Oracle UCM */
            if (string.IsNullOrWhiteSpace(q))
                q = "А";
            if (inTitle)
            {
                request = "dDocTitle <starts> `" + q.ToUpper() +
                                    "` <OR> dDocTitle <starts> `" + q.ToLower() +
                                    "`";
                sortField = "dDocTitle";
            }
            else
            {
                request =   "xDocAuthorsTPU_FIO <starts> `" + q.ToUpper() +
                            "` <OR> xDocAuthorsTPU_FIO <starts> `" + q.ToLower() +
                            "` <OR> xDocCoAuthors <starts> `" + q.ToUpper() +
                            "` <OR> xDocCoAuthors <starts> `" + q.ToLower() +
                            "`";
                sortField = "xDocAuthorsTPU_FIO";
            }
            
            /* Отправляем запрос к сервису Oracle UCM */
            AdvancedSearchResult searchResult = searchService.AdvancedSearch(request, sortField, "ASC", resultCount, true, extraProps);
            /* Обрабатываем ошибки при помощи исключений */
            if (searchResult == null) throw new Exception("Ваш запрос не был обработан сервером. Попробуйте позже");
            if (searchResult.StatusInfo.statusCode < 0) throw new Exception(searchResult.StatusInfo.statusMessage);
            if (searchResult.SearchInfo.totalRows.Equals(0) || (searchResult.SearchResults.Count() == 0))
                throw new Exception("По запросу \"" + q + "\" ничего не найдено. Попробуйте использовать другие ключевые слова.");

            CountResults = searchResult.SearchResults.Count();
            List<Document> documentsList = new List<Document>(CountResults);

            for (int i = 0; i < CountResults; i++)
            {
                documentsList.Add(new Document(searchResult.SearchResults[i]));
            }

            results = documentsList.AsQueryable();
        }
        
        
        public void FullTextSearch(String q)
        {
            String request;
            int resultCount = 100; // Количество выдаваемых результатов

            /* Формируем строку запросу к Oracle UCM */
            if (string.IsNullOrWhiteSpace(q)) request = "a";
            else request = "<ftx>" + q.ToLower() + "</ftx>";
            /* Отправляем запрос к сервису Oracle UCM */
            AdvancedSearchResult searchResult = searchService.AdvancedSearch(request, "dCreateDate", "DESC", resultCount, true, extraProps);
            /* Обрабатываем ошибки при помощи исключений */
            if (searchResult == null) throw new Exception("Ваш запрос не был обработан сервером. Попробуйте позже");
            if (searchResult.StatusInfo.statusCode < 0) throw new Exception(searchResult.StatusInfo.statusMessage);
            if (searchResult.SearchInfo.totalRows.Equals(0) || (searchResult.SearchResults.Count() == 0))
                throw new Exception("По запросу \"" + q + "\" ничего не найдено. Попробуйте использовать другие ключевые слова.");

            CountResults = searchResult.SearchResults.Count();
            List<Document> documentsList = new List<Document>(CountResults);

            for (int i = 0; i < CountResults; i++)
            {
                documentsList.Add(new Document(searchResult.SearchResults[i]));
            }

            results = documentsList.AsQueryable();
        }



        public void SimpleSearch(String q)
        {
            String request;
            int resultCount = 100; // Количество выдаваемых результатов
            
            /* Формируем строку запросу к Oracle UCM */
            if (string.IsNullOrWhiteSpace(q)) request = "a";
            else request =  "xDocAnnotation <substring> `" + q.ToLower() +
                            "` <OR> xDocAnnotation <substring> `" + q[0].ToString().ToUpper() + q.Substring(1).ToLower() +
                            "` <OR> xDocCaption <substring> `" + q.ToLower() +
                            "` <OR> xDocCaption <substring> `" + q[0].ToString().ToUpper() + q.Substring(1).ToLower() +
                            "` <OR> xDocKeyWords <substring> `" + q.ToLower() +
                            "` <OR> xDocKeyWords <substring> `" + q[0].ToString().ToUpper() + q.Substring(1).ToLower() +
                            "` <OR> xDocAuthorsTPU_FIO <substring> `" + q.ToLower() +
                            "` <OR> xDocAuthorsTPU_FIO <substring> `" + q[0].ToString().ToUpper() + q.Substring(1).ToLower() +
                            "`";
            /* Отправляем запрос к сервису Oracle UCM */
            AdvancedSearchResult searchResult = searchService.AdvancedSearch(request, "dCreateDate", "DESC", resultCount, true, extraProps);
            /* Обрабатываем ошибки при помощи исключений */
            if (searchResult == null) throw new Exception("Ваш запрос не был обработан сервером. Попробуйте позже");
            if (searchResult.StatusInfo.statusCode < 0) throw new Exception(searchResult.StatusInfo.statusMessage);
            if (searchResult.SearchInfo.totalRows.Equals(0) || (searchResult.SearchResults.Count() == 0))
                throw new Exception("По запросу \"" + q + "\" ничего не найдено. Попробуйте использовать другие ключевые слова.");

            CountResults = searchResult.SearchResults.Count();
            List<Document> documentsList = new List<Document>(CountResults);

            for (int i = 0; i < CountResults; i++)
            {
                documentsList.Add(new Document(searchResult.SearchResults[i]));
            }

            results = documentsList.AsQueryable();        
        }

    }
}
