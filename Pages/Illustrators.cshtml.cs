using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;

namespace ProjectComicBook.Pages
{
    public class Illustrators : PageModel
    {
        private readonly DatabaseHandler _databaseHandler = new DatabaseHandler();

        public void OnGet()
        {
            
        }
        
        
        public RedirectToPageResult OnPostAddIllustrator()
        {
            var illustratorName = Request.Form["illustratorName"];
            string illustratorDescription = Request.Form["illustratorDescription"];
            _databaseHandler.AddIllustrator(illustratorName, illustratorDescription);
            return RedirectToPage("./Index");
        }
    }
}