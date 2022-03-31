namespace ProjectComicBook.Models;

    public class CollectionComicBook
    {
        public int collectionID { get; set; }
        public int comicbookID { get; set; }
        public int userID { get; set; }
        public string quality { get; set; }
        public int height { get; set; }
        public int rating { get; set; }
        public int read { get; set; }
    }
