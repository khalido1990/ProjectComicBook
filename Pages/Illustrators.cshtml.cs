using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;
using ProjectComicBook.Repositories;

namespace ProjectComicBook.Pages
{
    public class Illustrators : PageModel
    {
        private readonly IllustratorRepository _illustratorRepository = new IllustratorRepository();

        public void OnGet()
        {
            
        }
        
        
        public RedirectToPageResult OnPostAddIllustrator()
        {
            var illustratorName = Request.Form["illustratorName"];
            string illustratorDescription = Request.Form["illustratorDescription"];
            _illustratorRepository.AddIllustrator(illustratorName, illustratorDescription);
            return RedirectToPage("./Index");
        }
    }
}