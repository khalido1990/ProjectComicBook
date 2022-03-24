using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjectComicBook.Models;

namespace ProjectComicBook.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private DatabaseHandler DatabaseHandler = new DatabaseHandler();


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
    }
}