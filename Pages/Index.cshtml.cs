using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjectComicBook.Models;
using ProjectComicBook.Pages.Shared;
using ProjectComicBook.Repositories;

namespace ProjectComicBook.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private DatabaseHandler DatabaseHandler = new DatabaseHandler();
        public string LUserDisplayString = "Login";
        
        public IndexModel(ILogger<IndexModel> logger, IEnumerable<ComicBook> comicBooks, IEnumerable<ComicBookAndAuthor> recentlyAddedComicBooks, IEnumerable<Author> authors, IEnumerable<Illustrator> illustrators)
        {
            _logger = logger;
            ComicBooks = comicBooks;
            RecentlyAddedComicBooks = recentlyAddedComicBooks;
        }

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

        public IEnumerable<ComicBook> ComicBooks{ get; set; }
        public IEnumerable<ComicBookAndAuthor>? RecentlyAddedComicBooks{ get; set; }

        public void OnGet()
        {
            ComicBooks = new ComicRepository().GetAllComicBooks();
            RecentlyAddedComicBooks = new ComicRepository().GetRecentlyAddedComicBooks();
        }
    }
}