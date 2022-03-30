using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;
using ProjectComicBook.Repositories;

namespace ProjectComicBook.Pages
{
    public class UpdateAuthor : PageModel
    {
        private readonly AuthorRepository _authorRepository = new AuthorRepository();

        public UpdateAuthor(IEnumerable<Author> authors)
        {
            Authors = authors;
        }
        public IEnumerable<Author> Authors{ get; set; }

        public void OnGet()
        {
            Authors = new AuthorRepository().GetAllAuthors();
        }
    
        public RedirectToPageResult OnPostDeleteAuthor()
        {
            string authorIDString = Request.Form["del-button"];
            int authorID = Convert.ToInt32(authorIDString);
            _authorRepository.DeleteAuthor(authorID);
            return RedirectToPage("./updateAuthor");
        }
    
        public RedirectToPageResult OnPostUpdateAuthor()
        {
            string authorName = Request.Form["authorName"];
            string authorDescription = Request.Form["authorDescription"];
            string authorIDString = Request.Form["upd-button"];
            int authorID = Convert.ToInt32(authorIDString);
            _authorRepository.UpdateAuthor(authorID, authorName, authorDescription);
            return RedirectToPage("./updateAuthor");
        }
    }
}