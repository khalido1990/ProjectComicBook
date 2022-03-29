using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using ProjectComicBook.Pages.Shared;

namespace ProjectComicBook.Pages;

//hier staan voorbeelden van de commandos van de CookieInfo static
public class CookieCallVoorbeelden : PageModel
{
    public string UserName;
    public string Password;
    public int UserRole;
    public int UserID;
    public string Name;
    public bool LoginBool;
    public void OnGet()
    {
        //Use this
        SharedInfo.AcountInfo = JsonConvert.DeserializeObject<user>(Request.Cookies["Global"]);

        if (SharedInfo.HasValidData)
        {
            //Get username
            UserName = SharedInfo.AcountInfo.username;
            //Get Password
            Password = SharedInfo.AcountInfo.password;
            //Get Name
            Name = SharedInfo.AcountInfo.name;
            //Get UserRole
            UserRole = SharedInfo.AcountInfo.role_ID;
            //Get UserID
            UserID =  SharedInfo.AcountInfo.userID;
            //Get the LoginBool
            LoginBool = SharedInfo.AcountInfo.StayLoggedIn;
        }
        
        
    }

    //logout by deleting the "Login Cookie"
    public void LogoutByCookie()
    {
        //cookies.Logout();
    }

    //Login by Using the "Login" Cookie can return null if it does not exist
    public void LoginByCookie()
    {
        //cookies.CookieLogin();
    }

    //Use this if another loginpage class has been made to refresh the stored one
    public void SetNewLoginPage()
    {
        //cookies.LogingPage = new Login();
    }
}