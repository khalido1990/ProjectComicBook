using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.DataProtection;
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

    public class Login : PageModel
    {
        [BindProperty] [MaxLength(25)] public string UserName { get; set; }
        
        [BindProperty] [MaxLength(25)] public string Password { get; set; }
        [BindProperty] [MaxLength(25)] public string Name { get; set; }
        [TempData] public bool KeepLoggedIn { get; set; }
        public string ErrorMsg = "";
        private user _user = new user();
        //claims
        public user SessionUser
        {
            get
            {
                if (SharedInfo.HasLegitCookie = CheckCookie())
                {
                    SharedInfo.SetUser(Setup());
                    return  _user = Setup();
                }
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

        
        public void OnGet()
        {
            ErrorMsg = MakeMsg("Welcome" + SessionUser.name);
        }

        public MyCookie GiveCookieInfo()
        {
            //MyCookie cookie = new MyCookie();
            MyCookie Cookie = JsonConvert.DeserializeObject<MyCookie>(Request.Cookies["Login"]);
            return Cookie;
        }



        public void OnPostLogout()
        {
            DeleteCookies();
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
                ErrorMsg = MakeMsg("Welcome" + " " + me.username);
                 

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