using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.SearchRef;
using DomainModel.Entity;
using System.Net;

namespace DomainModel
{
    public class DocSearch
    {
        private Search searchService = new Search();
        private IdcProperty[] extraProps = new IdcProperty[1];
        private IQueryable<Document> results;

        public IQueryable<Document> Results { get { return results;} }
        public String RequestString { get; set; }
        public String SortOrderString { get; set; }
        public String SortValueString { get; set; }
        public int CountResults { get; set; } //Найденные документы, соответствующие запросу
        public int CountRecords { get; set; } //Количество отображаемых записей
        

        public DocSearch()
        {
            searchService.Url = Constants.UrlToUCMServices;
            searchService.Credentials = new NetworkCredential(Constants.Login, Constants.Password);
        }
       
        /* return type IList<Document> */
        public void StartSearch(String request, String sortValue, String sortOreder, int countRec = 50)
        {
            AdvancedSearchResult searchResults = new AdvancedSearchResult();
            if (countRec < 1 || countRec > 50) countRec = 50;
            
            searchResults = searchService.AdvancedSearch(request, sortValue, sortOreder, countRec, true, extraProps);
 
            if (searchResults == null) throw new Exception("Ваш запрос не был обработан сервером. Попробуйте позже");
            if (searchResults.StatusInfo.statusCode < 0) throw new Exception(searchResults.StatusInfo.statusMessage);
            if (searchResults.SearchInfo.totalRows.Equals(0) || (searchResults.SearchResults.Count() == 0))
                throw new Exception("Запрашиваемая информация отсутсвует");


            CountResults = searchResults.SearchResults.Count();
            List<Document> documentsList = new List<Document>(CountResults);

            for (int i = 0; i < CountResults; i++)
            {
                documentsList.Add(new Document(searchResults.SearchResults[i]));
            }

            results = documentsList.AsQueryable();
            
        }

    }
}
