﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;
using ProjectComicBook.Repositories;

namespace ProjectComicBook.Pages
{
    public class Comicbooks : PageModel
    {
        // private readonly DatabaseHandler _databaseHandler = new DatabaseHandler();
        private readonly ComicRepository _comicRepository = new ComicRepository();
        public void OnGet()
        {

        }
        public RedirectToPageResult OnPostAddComic()
        {
            var title = Request.Form["title"];
            string descriptionComic = Request.Form["descriptionComic"];
            string isbn = Request.Form["isbn"];
            string releaseDate = Request.Form["releaseDate"];
            string type = Request.Form["type"];
            string pages = Request.Form["pages"];
            int serie_ID = 1;
            int authorID = 1;
            int illustratorID = 1;
            _comicRepository.AddComic(serie_ID, authorID, illustratorID, title, descriptionComic, isbn, releaseDate, type, pages);
            return RedirectToPage("./Index");
        }
    }
}