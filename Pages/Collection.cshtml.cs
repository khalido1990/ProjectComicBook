using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;
namespace ProjectComicBook.Pages;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using ProjectComicBook.Pages.Shared;
public class Collection : PageModel
{
    private int userID;
    private bool LoginBool;

    public IEnumerable<dynamic> UserCollection { get; set; }

    public void OnGet()
    {
        SharedInfo.AcountInfo = JsonConvert.DeserializeObject<user>(Request.Cookies["Global"]);
        userID = SharedInfo.AcountInfo.userID;
        LoginBool = SharedInfo.AcountInfo.StayLoggedIn;
        UserCollection = new DatabaseHandler().ViewCollection(userID);
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
    //vanavond opmaak fixen
    //verwijder uit collectie knop maken
    //if check maken die kijkt als er al iets in je collectie zit
}