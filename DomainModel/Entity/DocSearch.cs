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
        public int CallSearch(String request, String sortValue, String sortOreder, int countRec)
        {
            AdvancedSearchResult searchResults = searchService.AdvancedSearch(request, sortValue, sortOreder, countRec, true, extraProps);
            if (searchResults == null) throw new Exception("The request could not be processed");
            if (searchResults.StatusInfo.statusCode < 0) throw new Exception(searchResults.StatusInfo.statusMessage);
            if (searchResults.SearchInfo.totalRows.Equals(0) || (searchResults.SearchResults.Count() == 0))
                throw new Exception("Search results are not found");
            else
                CountResults = searchResults.SearchInfo.totalRows;
            return 0;
            //TODO : Записать поля результатов в класс Документ.
        }

    }
}
