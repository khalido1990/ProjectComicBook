using System;
using Microsoft.VisualBasic;

namespace ProjectComicBook.Models
{
    public class ComicBook
    {
        public int comicbookID { get; set; }
        public int serie_ID { get; set; }
        public string titel { get; set; }
        public string authorID { get; set; }
        public string isbn { get; set; }
        public string cover { get; set; }
   
        public string description { get; set; }
        public int pages { get; set; }
        public DateTime releaseDate { get; set; }

    }
}