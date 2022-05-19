namespace ProjectComicBook.Models
{
    public class ComicBookAndAuthor
    {
        public int comicbookID { get; set; }
        public string title { get; set; }
        public string isbn { get; set; }
        public string cover { get; set; }

        //Author
        public int authorID { get; set; }
        public string authorName { get; set; }
    }
}