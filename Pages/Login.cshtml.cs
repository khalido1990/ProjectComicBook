using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using ProjectComicBook.Pages.Shared;


namespace ProjectComicBook.Pages
{
    
    public class user
    {
        public int userID { get; set; }
        public int role_ID { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool StayLoggedIn { get; set; }

        public user()
        {
            
        }
        public user(string userName, string password, bool keepLoggedIn)
        {
            this.username = userName;
            this.password = password;
            StayLoggedIn = keepLoggedIn;
        }
        
    }

    public class MyCookie
    {
        public string Password;
        public string UserName;
        public bool StayLoggedIn;

        public MyCookie(string UserName, string Password, bool StayLoggedIn)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.StayLoggedIn = StayLoggedIn;
        }
        
    }

    //this class handles the login
    public class Login : PageModel
    {
        [BindProperty] [MaxLength(25)] public string UserName { get; set; }
        
        [BindProperty] [MaxLength(25)] public string Password { get; set; }
        [BindProperty] [MaxLength(25)] public string Name { get; set; }

        
        [TempData] public bool KeepLoggedIn { get; set; }
        //An String that is used for the logging of messages
        public string ErrorMsg = "";

        public string LogoutText = "";

        public bool HideLogout = false;
        //create a new user class
        private user _user = new user();
        //claims
        //create a get set for a session user
        public user SessionUser
        {
            get
            {
                //Set the haslegitcookie from the shared info with the checkcookie result
                if (SharedInfo.HasLegitCookie = CheckCookie())
                {
                    //from the shared info insert the new user information that is returned from setup
                    SharedInfo.SetUser(Setup());
                    HideLogout = false;
                    return  _user = Setup();
                }

                HideLogout = true;
                return this._user;
            }
            set
            {
                //check if there is a cookie
                if (CheckCookie())
                {
                    //call the setup to create an user
                    _user = Setup();
                }
            }
        }
        
        
        public DatabaseHandler Handler = new DatabaseHandler();

        //on the start displays initial messages
        public void OnGet()
        {
            //check if the username is not null
            if (SessionUser.name != null)
            {
                //make the new msg that will be shown on the html page
                ErrorMsg = MakeMsg("Welcome" + "" + SessionUser.name);
            }
            else
            {
                //make a new msg 
                ErrorMsg = MakeMsg("Please Login");
            }
        }
        


        public void OnPostLogout()
        {
            DeleteCookies();
            HideLogout = true;
        }
        //Handle the login with a post method
        public void OnPostLogin(string UserName, string Password, bool KeepLoggedIn)
        {
            user me = Handler.GetUserNow(UserName, Password);
            if (me.username == UserName)
            {
                me.StayLoggedIn = KeepLoggedIn;
                //create a new My cookie class
                MyCookie cookie= new MyCookie(UserName, Password, KeepLoggedIn);
                //Delete Old cookie
                DeleteCookies();
                //create new cookie
                Response.Cookies.Append("Login", JsonConvert.SerializeObject(cookie), new CookieOptions());
                SharedInfo.DisplayName(me.name);
                SharedInfo.HasLegitCookie = true;
                HideLogout = false;
                ErrorMsg = MakeMsg("Welcome" + " " + me.username);
                Response.Cookies.Append("Global", JsonConvert.SerializeObject(me), new CookieOptions());
                 

            }
            else
            {
                ErrorMsg = MakeMsg("Wrong username or password");
                
            }
        }

        //delete cookie
        public void DeleteCookies()
        {
            Response.Cookies.Delete("Login");
        }
        
        //setup to extract an user from the database using a cookie
        public user Setup()
        {
            MyCookie cookie = JsonConvert.DeserializeObject<MyCookie>(Request.Cookies["Login"]);
            SharedInfo.SetCookie(cookie);
            if (Request.Cookies["Login"] != null)
            {
                user me = Handler.GetUserNow(cookie.UserName, cookie.Password);
                return me;
            }

            //return an new empty user class
            return new user();
        }

        public bool CheckCookie()
        {
            if (Request.Cookies["Login"] != null)
            {
                return true;
            }

            return false;
        }

        public string HashVal(string pass)
        {
            var passHasher = new PasswordHasher<string>();
            return pass = passHasher.HashPassword(null,pass);
            
        }
        private string MakeMsg(string msg)
        {
            return msg;
        }


    }
}