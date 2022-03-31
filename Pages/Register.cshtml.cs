using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using ProjectComicBook.Models;

namespace ProjectComicBook.Pages
{
    public class Register : PageModel
    {
        // public Register(string errorMsg, string userName, string password, string name, string cpassword, bool keepLoggedIn, string nameDisplay)
        // {
        //     ErrorMsg = errorMsg;
        //     UserName = userName;
        //     Password = password;
        //     Name = name;
        //     Cpassword = cpassword;
        //     KeepLoggedIn = keepLoggedIn;
        //     NameDisplay = nameDisplay;
        // }
        [BindProperty] [MaxLength(25)] public string UserName { get; set; }
        
        [BindProperty] [MaxLength(25)] public string Password { get; set; }
        [BindProperty] [MaxLength(25)] public string Name { get; set; }
        [TempData, Required, Compare(nameof(Password))] public string Cpassword { get; set; }
        [TempData] public bool KeepLoggedIn { get; set; }
        public string NameDisplay { get; set; }
        public string ErrorMsg = "";
        private user _user = new user();
        public DatabaseHandler Handler = new DatabaseHandler();

        public void OnGet()
        {
        }
        public void OnPostReg(string UserName, string Password, string Name, string Cpassword)
        {
            
            if (!Handler.CheckForDoubleEntry(UserName, Name))
            {
                Handler.AddNewUser(UserName, HashVal(Password), Name);
                ErrorMsg = MakeMsg("Welcome" + " " + Name);
                MyCookie cookie = new MyCookie(UserName, Password, KeepLoggedIn);
                Response.Cookies.Append("Login", JsonConvert.SerializeObject(cookie), new CookieOptions());
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