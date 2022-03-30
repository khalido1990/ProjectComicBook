using System;
using System.Collections.Generic;
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

    public IEnumerable<object> UserCollection { get; set; }

    public void OnGet()
    {
        SharedInfo.AcountInfo = JsonConvert.DeserializeObject<user>(Request.Cookies["Global"]);
        if (SharedInfo.HasValidData)
        {
            UserCollection = new DatabaseHandler().ViewCollection(userID);
            userID =  SharedInfo.AcountInfo.userID;
            LoginBool = SharedInfo.AcountInfo.StayLoggedIn;
            //UserCollection = new DatabaseHandler().ViewCollection(userID);
        }
        else
        {
            UserCollection = new DatabaseHandler().ViewCollection(0);
        }
    }

    

    public RedirectToPageResult OnPostRemoveFromCollection()
    {
        return RedirectToPage("./updateIllustrator");
    }

}