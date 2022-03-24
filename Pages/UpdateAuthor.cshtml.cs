using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;

namespace ProjectComicBook.Pages
{
    public class UpdateAuthor : PageModel
    {
        private readonly DatabaseHandler _databaseHandler = new DatabaseHandler();

        public UpdateAuthor(IEnumerable<dynamic> authors)
        {
            Authors = authors;
        }
        public IEnumerable<dynamic> Authors{ get; set; }

        public void OnGet()
        {
            Authors = new DatabaseHandler().GetAllAuthors();
        }
    
        public RedirectToPageResult OnPostDeleteAuthor()
        {
            string authorIDString = Request.Form["del-button"];
            int authorID = Convert.ToInt32(authorIDString);
            _databaseHandler.DeleteAuthor(authorID);
            return RedirectToPage("./updateAuthor");
        }
    
        public RedirectToPageResult OnPostUpdateAuthor()
        {
            string authorName = Request.Form["authorName"];
            string authorDescription = Request.Form["authorDescription"];
            string authorIDString = Request.Form["upd-button"];
            int authorID = Convert.ToInt32(authorIDString);
            _databaseHandler.UpdateAuthor(authorID, authorName, authorDescription);
            return RedirectToPage("./updateAuthor");
        }
    }
}