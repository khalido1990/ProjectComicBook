using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;

namespace ProjectComicBook.Pages
{
    public class Illustrators : PageModel
    {
        private DatabaseHandler DatabaseHandler = new DatabaseHandler();

        public void OnGet()
        {
            
        }
        
        
        public RedirectToPageResult OnPostAddIllustrator()
        {
            var illustratorName = Request.Form["illustratorName"];
            string illustratorDescription = Request.Form["illustratorDescription"];
            DatabaseHandler.AddIllustrator(illustratorName, illustratorDescription);
            return RedirectToPage("./Index");
        }
    }
}