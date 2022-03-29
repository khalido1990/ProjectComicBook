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
using Ubiety.Dns.Core;
using static Newtonsoft.Json.JsonConvert;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;
namespace ProjectComicBook.Pages.Shared;

public class MakeCookie
{
    public void MakeglobalVar()
    {
        //JsonConvert.SerializeObject<SharedInfo>(SharedInfo)
    }
}

//global class containing Global user  info 
public static class SharedInfo
{
    //An static for global naming 
    
    public static string UserNameString = "Login";
    //bool if cookie is good Needs to be true to get use out of this class
    public static bool HasLegitCookie = false;
    public static bool HasValidData = false;

    //most important the acount info
    public static user AcountInfo;
    //the global cookie
    public static MyCookie GlobalCookie;
    //set a new displayname by using this method
    public static void DisplayName(string status)
    {
        UserNameString = status;
    }

    //set a new user by using this method 
    public static void SetUser(user gebruiker)
    {
        AcountInfo = gebruiker;
    }

    //set a new cookie by using this method
    public static void SetCookie(MyCookie cookie)
    {
        GlobalCookie = cookie;
    }

    public static void SaveAsCookie()
    {
        
        //JsonConvert.SerializeObject(<SharedInfo>);
    }

    //Check the integrity of this class returns true if it all is filled
    public static bool CheckIntegrity()
    {
        if (AcountInfo.name != null && GlobalCookie.UserName != null)
        {
            return true;
        }
        return false;
    }
    
}