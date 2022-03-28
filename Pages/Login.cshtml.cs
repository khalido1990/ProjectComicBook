using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectComicBook.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;

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
    
        [Required] [BindProperty] [MaxLength(25)] public string UserName { get; set; }
        
        [Required] [BindProperty] [MaxLength(25)] public string Password { get; set; }
        [Required] [BindProperty] [MaxLength(25)] public string Name { get; set; }
        [TempData, Required, Compare(nameof(Password))] public string Cpassword { get; set; }
        [TempData] public bool KeepLoggedIn { get; set; }
        public string NameDisplay { get; set; }
        public string ErrorMsg = "";
        private user _user;
        

        public user SessionUser
        {
            get
            {
                return this._user;
            }
            set
            {
                if (CheckCookie())
                {
                    _user = Setup();
                }
            }
        }
        
        public DatabaseHandler Handler = new DatabaseHandler();


        public void OnGet()
        {
            SessionUser = new user();
        }

        public void OnPostLogout()
        {
            DeleteCookies();
        }
        public void OnPostLogin(string UserName, string Password, bool KeepLoggedIn)
        {
            user me = Handler.GetUserNow(UserName, Password);
            if (me.username == UserName)
            {
                me.StayLoggedIn = KeepLoggedIn;
                MyCookie cookie = new MyCookie(UserName, Password, KeepLoggedIn);
                DeleteCookies();
                Response.Cookies.Append("Login", JsonConvert.SerializeObject(cookie), new CookieOptions());
                ErrorMsg = MakeMsg("Welcome" + " " + me.username);

            }
            else
            {
                ErrorMsg = MakeMsg("Wrong username or password");
            }
        }

        public void DeleteCookies()
        {
            Response.Cookies.Delete("Login");
        }
        public user Setup()
        {
            MyCookie cookie = JsonConvert.DeserializeObject<MyCookie>(Request.Cookies["Login"]);
            if (Request.Cookies["Login"] != null)
            {
                user me = Handler.GetUserNow(cookie.UserName, cookie.Password);
                return me;
            }

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

        public void OnPostReg(string UserName, string Password, string Name, string Cpassword)
        {
            
            if (!Handler.CheckForDoubleEntry(UserName, Name))
            {
                Handler.AddNewUser(UserName, HashVal(Password), Name);
                ErrorMsg = MakeMsg("Welcome" + " " + Name);
            }
            else
            {
                ErrorMsg = MakeMsg(Handler.CheckForDoubleEntryName(Name) ? "Name already taken" : "Username already taken");
            }
            
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