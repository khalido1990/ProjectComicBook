using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjectComicBook.Models;
using ProjectComicBook.Pages.Shared;
using Microsoft.AspNetCore.Mvc;


namespace ProjectComicBook.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private DatabaseHandler DatabaseHandler = new DatabaseHandler();
        public string LUserDisplayString = "Login";

        public string TestString
        {
            get
            {
                return LUserDisplayString;
            }
            set
            {
                LUserDisplayString = value;
            }
        }

        public static string UserDisplayString
        {
            get
            {
                return SharedInfo.UserNameString;
            }
            set
            {
                
                UserDisplayString = value;
            }
        }


        public IndexModel(ILogger<IndexModel> logger, IEnumerable<dynamic> comicBooks, IEnumerable<dynamic> recentlyAddedComicBooks, IEnumerable<dynamic> authors, IEnumerable<dynamic> illustrators)
        {
            _logger = logger;
            ComicBooks = comicBooks;
            RecentlyAddedComicBooks = recentlyAddedComicBooks;
            Authors = authors;
            Illustrators = illustrators;
        }

        public IEnumerable<dynamic> ComicBooks{ get; set; }
        public IEnumerable<dynamic> RecentlyAddedComicBooks{ get; set; }
        public IEnumerable<dynamic> Authors{ get; set; }
        public IEnumerable<dynamic> Illustrators { get; set; }

        public void OnGet()
        {
            ComicBooks = new DatabaseHandler().GetAllComicBooks();
            RecentlyAddedComicBooks = new DatabaseHandler().GetRecentlyAddedComicBooks();
            Authors = new DatabaseHandler().GetAllAuthors();
            Illustrators = new DatabaseHandler().GetAllIllustrators();
        }
        
        public RedirectToPageResult OnPostAddToCollection()
        {
            string comicbookIDstring = Request.Form["addBook"];
            int comicbookID = Convert.ToInt32(comicbookIDstring);
            int userID = 1;
            DatabaseHandler.AddToCollection(comicbookID, userID);
            return RedirectToPage("./index");
        }
    }
}