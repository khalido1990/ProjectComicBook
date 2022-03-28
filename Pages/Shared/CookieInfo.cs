using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using ProjectComicBook.Pages.Shared;
using static Newtonsoft.Json.JsonConvert;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;
namespace ProjectComicBook.Pages.Shared;



//global class containing Global user  info 
public static class SharedInfo
{
    //An static for global naming 
    public static string UserNameString = "Login";
    //bool if cookie is good Needs to be true to get use out of this class
    public static bool HasLegitCookie = false;

    //most important the acount info
    public static user AcountInfo;
    public static MyCookie GlobalCookie;
    public static void DisplayName(string status)
    {
        UserNameString = status;
    }

    public static void SetUser(user gebruiker)
    {
        AcountInfo = gebruiker;
    }

    public static void SetCookie(MyCookie cookie)
    {
        GlobalCookie = cookie;
    }
    
}