using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;
using ProjectComicBook.Repositories;

namespace ProjectComicBook.Pages
{
    public class UpdateComicbooks : PageModel
    {
        private readonly ComicRepository _comicRepository = new ComicRepository();
        public UpdateComicbooks(IEnumerable<ComicBook> comicbooks)
        {
            Comicbooks = comicbooks;
        }
        public IEnumerable<ComicBook> Comicbooks{ get; set; }

        public void OnGet()
        {
            Comicbooks = new ComicRepository().GetAllComicBooks();
        }
    
        public RedirectToPageResult OnPostDeleteComicbook()
        {
            string comicbookIDString = Request.Form["del-button"];
            int comicbookID = Convert.ToInt32(comicbookIDString);
            _comicRepository.DeleteComicbook(comicbookID);
            return RedirectToPage("./updateComicbooks");
        }
    
        public RedirectToPageResult OnPostUpdateComicbook()
        {
            string comicbookIDString = Request.Form["upd-button"];
            int comicbookID = Convert.ToInt32(comicbookIDString);
            var title = Request.Form["title"];
            string descriptionComic = Request.Form["descriptionComic"];
            string isbn = Request.Form["isbn"];
            string releaseDate = Request.Form["releaseDate"];
            string type = Request.Form["type"];
            string pages = Request.Form["pages"];
            int serie_ID = 1;
            int authorID = 1;
            int illustratorID = 1;
            int explicitComic = 1;
            _comicRepository.UpdateComicbook(comicbookID, serie_ID, authorID, illustratorID, title, descriptionComic, isbn, releaseDate, type, pages, explicitComic);
            return RedirectToPage("./updateComicbooks");
        }
    }
}