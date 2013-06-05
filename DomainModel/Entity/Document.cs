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
        }
    }
}
