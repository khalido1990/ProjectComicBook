using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjectComicBook.Models;

namespace ProjectComicBook.Pages;

public class UpdateAuthor : PageModel
{
    private DatabaseHandler DatabaseHandler = new DatabaseHandler();
    
    public IEnumerable<dynamic> Authors{ get; set; }

    public void OnGet()
    {
        Authors = new DatabaseHandler().GetAllAuthors();
    }
    
    public RedirectToPageResult OnPostDeleteAuthor()
    {
        string authorIDString = Request.Form["del-button"];
        int authorID = Convert.ToInt32(authorIDString);
        DatabaseHandler.DeleteAuthor(authorID);
        return RedirectToPage("./updateAuthor");
    }
    
    public RedirectToPageResult OnPostUpdateAuthor()
    {
        string authorName = Request.Form["authorName"];
        string authorDescription = Request.Form["authorDescription"];
        string authorIDString = Request.Form["upd-button"];
        int authorID = Convert.ToInt32(authorIDString);
        DatabaseHandler.UpdateAuthor(authorID, authorName, authorDescription);
        return RedirectToPage("./updateAuthor");
    }
}