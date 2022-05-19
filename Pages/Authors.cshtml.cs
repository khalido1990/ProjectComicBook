using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;
using ProjectComicBook.Repositories;

namespace ProjectComicBook.Pages
{
    public class Authors : PageModel
    {
        private readonly AuthorRepository _authorRepository = new AuthorRepository();
        public void OnGet()
        {

        }

        public RedirectToPageResult OnPostAddAuthor()
        {
            var authorName = Request.Form["authorName"];
            string authorDescription = Request.Form["authorDescription"];
            _authorRepository.AddAuthor(authorName, authorDescription);
            return RedirectToPage("./Index");
        }
    }
}