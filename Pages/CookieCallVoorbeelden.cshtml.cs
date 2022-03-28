using Microsoft.AspNetCore.Mvc.RazorPages;
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
        /*
        //Get username
        UserName = cookies.User.username;
        //Get Password
        Password = cookies.User.password;
        //Get Name
        Name = cookies.User.name;
        //Get UserRole
        UserRole = cookies.User.role_ID;
        //Get UserID
        UserID = cookies.User.userID;
        //Get the LoginBool
        LoginBool = cookies.User.StayLoggedIn;
        */
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