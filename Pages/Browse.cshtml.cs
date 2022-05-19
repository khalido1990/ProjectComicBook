using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;
using ProjectComicBook.Repositories;

namespace ProjectComicBook.Pages
{
    public class Browse : PageModel
    {
        public Browse(IEnumerable<ComicBook>? getAllComicBooks)
        {
            GetAllComicBooks = getAllComicBooks;
        }
        public IEnumerable<ComicBook>? GetAllComicBooks { get; set; }
        public void OnGet()
        {
            GetAllComicBooks = new ComicRepository().GetAllComicBooks();

        }
    }
}