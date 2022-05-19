using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using ProjectComicBook.Models;

namespace ProjectComicBook.Pages
{
    public class Collection : PageModel
    {
        private int userID;
        private bool LoginBool;

        public IEnumerable<dynamic> UserCollection { get; set; }
        private DatabaseHandler DatabaseHandler = new DatabaseHandler();

        public void OnGet()
        {
            try
            {
                SharedInfo.AcountInfo = JsonConvert.DeserializeObject<user>(Request.Cookies["Global"]);
                userID = SharedInfo.AcountInfo.userID;
                LoginBool = SharedInfo.AcountInfo.StayLoggedIn;
                UserCollection = new DatabaseHandler().ViewCollection(userID);
            }
            catch (Exception yeet)
            {
                Console.WriteLine(yeet);
            }

        }

        public RedirectToPageResult OnPostRemoveFromCollection()
        {
            SharedInfo.AcountInfo = JsonConvert.DeserializeObject<user>(Request.Cookies["Global"]);
            userID = SharedInfo.AcountInfo.userID;
            string comicbookIDstring = Request.Form["del-button"];
            int comicbookID = Convert.ToInt32(comicbookIDstring);
            UserCollection = new DatabaseHandler().RemoveFromCollection(comicbookID, userID);
            return RedirectToPage("./Collection");
        }
        public RedirectToPageResult OnPostAddToCollection()
        {
            string comicbookIDstring = Request.Form["addBook"];
            int comicbookID = Convert.ToInt32(comicbookIDstring);
            int userID = 1;
            DatabaseHandler.AddToCollection(comicbookID, userID);
            return RedirectToPage("./UpdateComicbooks");
        }
    }
}