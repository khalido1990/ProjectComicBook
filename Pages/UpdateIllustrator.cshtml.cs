using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjectComicBook.Models;



namespace ProjectComicBook.Pages;

public class UpdateIllustrator : PageModel
{
    private DatabaseHandler DatabaseHandler = new DatabaseHandler();
    
    public IEnumerable<dynamic> Illustrators{ get; set; }

    public void OnGet()
    {
        Illustrators = new DatabaseHandler().GetAllIllustrators();
    }
    
    public RedirectToPageResult OnPostDeleteIllustrator()
    {
        string illustratorIDString = Request.Form["del-button"];
        int illustratorID = Convert.ToInt32(illustratorIDString);
        DatabaseHandler.DeleteIllustrator(illustratorID);
        return RedirectToPage("./updateIllustrator");
    }
    
    public RedirectToPageResult OnPostUpdateIllustrator()
    {
        string illustratorName = Request.Form["illustratorName"];
        string illustratorDescription = Request.Form["illustratorDescription"];
        string illustratorIDString = Request.Form["upd-button"];
        int illustratorID = Convert.ToInt32(illustratorIDString);
        DatabaseHandler.UpdateIllustrator(illustratorID, illustratorName, illustratorDescription);
        return RedirectToPage("./updateIllustrator");
    }
}