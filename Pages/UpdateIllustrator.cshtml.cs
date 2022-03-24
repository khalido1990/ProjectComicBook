using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;

namespace ProjectComicBook.Pages
{
    public class UpdateIllustrator : PageModel
    {
        private readonly DatabaseHandler _databaseHandler = new DatabaseHandler();

        public UpdateIllustrator(IEnumerable<dynamic> illustrators)
        {
            Illustrators = illustrators;
        }
        public IEnumerable<dynamic> Illustrators{ get; set; }

        public void OnGet()
        {
            Illustrators = new DatabaseHandler().GetAllIllustrators();
        }
    
        public RedirectToPageResult OnPostDeleteIllustrator()
        {
            string illustratorIDString = Request.Form["del-button"];
            int illustratorID = Convert.ToInt32(illustratorIDString);
            _databaseHandler.DeleteIllustrator(illustratorID);
            return RedirectToPage("./updateIllustrator");
        }
    
        public RedirectToPageResult OnPostUpdateIllustrator()
        {
            string illustratorName = Request.Form["illustratorName"];
            string illustratorDescription = Request.Form["illustratorDescription"];
            string illustratorIDString = Request.Form["upd-button"];
            int illustratorID = Convert.ToInt32(illustratorIDString);
            _databaseHandler.UpdateIllustrator(illustratorID, illustratorName, illustratorDescription);
            return RedirectToPage("./updateIllustrator");
        }
    }
}