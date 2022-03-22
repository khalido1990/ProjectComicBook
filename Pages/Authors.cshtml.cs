using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;

namespace ProjectComicBook.Pages
{
    public class Authors : PageModel
    {
        private DatabaseHandler DatabaseHandler = new DatabaseHandler();
        public void OnGet()
        {
            
        }

        public RedirectToPageResult OnPostAddAuthor()
        {
            var authorName = Request.Form["authorName"];
            string authorDescription = Request.Form["authorDescription"];
            DatabaseHandler.AddAuthor(authorName, authorDescription);
            return RedirectToPage("./Index");
        }
    }
}