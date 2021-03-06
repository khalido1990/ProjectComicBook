using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;
using ProjectComicBook.Repositories;

namespace ProjectComicBook.Pages
{
    public class SearchResult : PageModel
    {
        [BindProperty (SupportsGet = true)]
        public string Search {get;set;}
    
        public List<ComicBook> comics { get; set; }

        public IActionResult OnGet(string Search)
        {
            var comic = new ComicRepository();
            comics = comic.Search(Search); 
            return Page();
        }
    }
}