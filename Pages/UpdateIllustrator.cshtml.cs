using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;
using ProjectComicBook.Repositories;

namespace ProjectComicBook.Pages
{
    public class UpdateIllustrator : PageModel
    {
        private readonly IllustratorRepository _illustratorRepository = new IllustratorRepository();

        public UpdateIllustrator(IEnumerable<Illustrator> illustrators)
        {
            Illustrators = illustrators;
        }
        public IEnumerable<dynamic> Illustrators{ get; set; }

        public void OnGet()
        {
            Illustrators = new IllustratorRepository().GetAllIllustrators();
        }
    
        public RedirectToPageResult OnPostDeleteIllustrator()
        {
            string illustratorIDString = Request.Form["del-button"];
            int illustratorID = Convert.ToInt32(illustratorIDString);
            _illustratorRepository.DeleteIllustrator(illustratorID);
            return RedirectToPage("./updateIllustrator");
        }
    
        public RedirectToPageResult OnPostUpdateIllustrator()
        {
            string illustratorName = Request.Form["illustratorName"];
            string illustratorDescription = Request.Form["illustratorDescription"];
            string illustratorIDString = Request.Form["upd-button"];
            int illustratorID = Convert.ToInt32(illustratorIDString);
            _illustratorRepository.UpdateIllustrator(illustratorID, illustratorName, illustratorDescription);
            return RedirectToPage("./updateIllustrator");
        }
    }
}