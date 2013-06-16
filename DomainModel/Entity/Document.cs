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
        public string Type { get; set; }
        public string Author { get ; set; }
        public string CoAuthor { get; set; }
        public string CreateDate { get; set; }
        public int FileSize { get; set; }
        public string Extension { get; set; }
        public string Format { get; set; }
        public string ShortTitle { get; set; }
        public string InDate { get; set; }
        public string FullTitle { get; set; }
        public string Keywords { get; set; }
        public string Annotation { get; set; }
        public string Title { get; set; }


        
        public Document(ContentInfo contentInfo)
        {
            this.ID = contentInfo.dID;
            this.Name = contentInfo.dDocName;
            this.Type = contentInfo.dDocType;
            this.Author = (contentInfo.xDocAuthorsTPU_FIO != "") 
                ? contentInfo.xDocAuthorsTPU_FIO.TrimEnd(',')
                : "Отсутствует";
            this.CreateDate = contentInfo.dCreateDate;
            this.FileSize = contentInfo.dFileSize;

            if (contentInfo.dExtension.Length > 4 && contentInfo.dFormat.Length > 16)
            {
                this.Format = contentInfo.dFormat.Remove(contentInfo.dFormat.IndexOf('#'));
                this.Extension = contentInfo.dExtension.Remove(contentInfo.dExtension.IndexOf('#'));
            }
            else
            {
                this.Extension = contentInfo.dExtension;
                this.Format = contentInfo.dFormat;
            }

            this.ShortTitle = (contentInfo.xDocCaption != null && contentInfo.xDocCaption.Length > 100) 
                ? contentInfo.xDocCaption.Remove(99) 
                + "..." : contentInfo.xDocCaption;
            this.FullTitle = contentInfo.xDocCaption;
            this.InDate = contentInfo.dInDate;
            this.CoAuthor = (contentInfo.xDocCoAuthors != "")
                ? contentInfo.xDocCoAuthors.TrimEnd(',')
                : "Отсутствует";
            this.Keywords = (contentInfo.xDocKeyWords != "")
                ? contentInfo.xDocKeyWords.TrimEnd(',')
                : "Отсутствует";
            this.Annotation = (contentInfo.xDocAnnotation != "")
                ? contentInfo.xDocAnnotation.TrimEnd(',')
                : "Отсутствует";
            this.Title = contentInfo.dDocTitle;

        }

        public Document(FileInfo fileInfo)
        {
            this.ID = fileInfo.dID;
            this.Name = fileInfo.dDocName;
            this.Type = fileInfo.dDocType;
            this.Author = fileInfo.xDocAuthorsTPU_FIO.TrimEnd(',');
            this.CreateDate = fileInfo.dCreateDate;
            this.FileSize = fileInfo.dFileSize;

            if (fileInfo.dExtension.Length > 4 && fileInfo.dFormat.Length > 16)
            {
                this.Format = fileInfo.dFormat.Remove(fileInfo.dFormat.IndexOf('#'));
                this.Extension = fileInfo.dExtension.Remove(fileInfo.dExtension.IndexOf('#'));
            }
            else
            {
                this.Extension = fileInfo.dExtension;
                this.Format = fileInfo.dFormat;
            }

            this.ShortTitle = (fileInfo.xDocCaption != null && fileInfo.xDocCaption.Length > 100)
                ? fileInfo.xDocCaption.Remove(99)
                + "..." : fileInfo.xDocCaption;
            this.FullTitle = fileInfo.xDocCaption;
            this.InDate = fileInfo.dInDate;
            this.CoAuthor = fileInfo.xDocCoAuthors;
            this.Keywords = fileInfo.xDocKeyWords.TrimEnd(',');
            this.Annotation = fileInfo.xDocAnnotation;
            this.Title = fileInfo.dDocTitle;
        }

        public Document(SearchResults searchResults)
        {
            
            this.ID = searchResults.dID;
            this.Name = searchResults.dDocName;
            this.Type = searchResults.dDocType;
            this.Author = (searchResults.xDocAuthorsTPU_FIO != "")
                ? searchResults.xDocAuthorsTPU_FIO.TrimEnd(',')
                : "Не указаны";
            this.CreateDate = searchResults.dInDate;
            this.FileSize = searchResults.alternateFileSize;

            if (searchResults.dExtension.Length > 4 && searchResults.dFormat.Length > 16)
            {
                this.Format = searchResults.dFormat.Remove(searchResults.dFormat.IndexOf('#'));
                this.Extension = searchResults.dExtension.Remove(searchResults.dExtension.IndexOf('#'));
            }
            else
            {
                this.Extension = searchResults.dExtension;
                this.Format = searchResults.dFormat;
            }

            if (string.IsNullOrWhiteSpace(searchResults.xDocCaption))
            {
                this.ShortTitle = "Отсутствует";
                this.FullTitle = "Отсутствует";
            }
            else
            {
                this.ShortTitle = (searchResults.xDocCaption != null && searchResults.xDocCaption.Length > 100)
                    ? searchResults.xDocCaption.Remove(99)
                    + "..." : searchResults.xDocCaption;
                this.FullTitle = searchResults.xDocCaption;
            }
            this.InDate = searchResults.dInDate;
            this.CoAuthor = searchResults.xDocCoAuthors;
            this.Keywords = searchResults.xDocKeyWords.TrimEnd(',');
            this.Annotation = searchResults.xDocAnnotation;
            this.Title = searchResults.dDocTitle;
        }
    }
}
