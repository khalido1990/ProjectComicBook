using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;

namespace ProjectComicBook.Pages
{
    public class Authors : PageModel
    {
        private readonly DatabaseHandler _databaseHandler = new DatabaseHandler();
        public void OnGet()
        {
            
        }

        public RedirectToPageResult OnPostAddAuthor()
        {
            var authorName = Request.Form["authorName"];
            string authorDescription = Request.Form["authorDescription"];
            _databaseHandler.AddAuthor(authorName, authorDescription);
            return RedirectToPage("./Index");
        }
    }
}