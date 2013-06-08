using DomainModel.DocInfoRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.GetFileRef;
using DomainModel.SearchRef;

namespace DomainModel.Entity
{
    public class Document 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Author { get; set; }
        public string CreateDate { get; set; }
        public int FileSize { get; set; }
        public string Extension { get; set; }
        public string Format { get; set; }
        public string ShortTitle { get; set; }
        public string InDate { get; set; }
        public string FullTitle { get; set; }



        
        public Document(ContentInfo contentInfo)
        {
            this.ID = contentInfo.dID;
            this.Name = contentInfo.dDocName;
            this.Title = contentInfo.dDocTitle;
            this.Type = contentInfo.dDocType;
            this.Author = contentInfo.dDocAuthor;
            this.CreateDate = contentInfo.dCreateDate;
            this.FileSize = contentInfo.dFileSize;
            this.Extension = contentInfo.dExtension;
            this.Format = contentInfo.dFormat;
            this.ShortTitle = (contentInfo.dOriginalName != null && contentInfo.dOriginalName.Length > 25) 
                ? contentInfo.dOriginalName.Remove(24) 
                + "..." : contentInfo.dOriginalName;
            this.FullTitle = contentInfo.dOriginalName;
            this.InDate = contentInfo.dInDate;


        }

        public Document(FileInfo fileInfo)
        {
            this.ID = fileInfo.dID;
            this.Name = fileInfo.dDocName;
            this.Title = fileInfo.dDocTitle;
            this.Type = fileInfo.dDocType;
            this.Author = fileInfo.dDocAuthor;
            this.CreateDate = fileInfo.dCreateDate;
            this.FileSize = fileInfo.dFileSize;
            this.Extension = fileInfo.dExtension;
            this.Format = fileInfo.dFormat;
            this.ShortTitle = (fileInfo.dOriginalName != null && fileInfo.dOriginalName.Length > 25)
                ? fileInfo.dOriginalName.Remove(24)
                + "..." : fileInfo.dOriginalName;
            this.FullTitle = fileInfo.dOriginalName;
            this.InDate = fileInfo.dInDate;
  

        }

        public Document(SearchResults searchResults)
        {
            this.ID = searchResults.dID;
            this.Name = searchResults.dDocName;
            this.Title = searchResults.dDocTitle;
            this.Type = searchResults.dDocType;
            this.Author = searchResults.dDocAuthor;
            this.CreateDate = searchResults.dInDate;
            this.FileSize = searchResults.alternateFileSize;
            this.Extension = searchResults.dExtension;
            this.Format = searchResults.dFormat;
            this.ShortTitle = (searchResults.dOriginalName != null && searchResults.dOriginalName.Length > 25)
                ? searchResults.dOriginalName.Remove(24)
                + "..." : searchResults.dOriginalName;
            this.FullTitle = searchResults.dOriginalName;
            this.InDate = searchResults.dInDate;

        }
    }
}
