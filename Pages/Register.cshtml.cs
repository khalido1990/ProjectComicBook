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

            //check if the name or username is already in the database
            if (!Handler.CheckForDoubleEntry(UserName, Name))
            {
                //add the new user in the database and hash the password
                Handler.AddNewUser(UserName, HashVal(Password), Name);
                //make a new msg to welcome the user
                ErrorMsg = MakeMsg("Welcome" + " " + Name);
                //create a new cookie 
                MyCookie cookie = new MyCookie(UserName, Password, KeepLoggedIn);
                //post the new cookie
                Response.Cookies.Append("Login", JsonConvert.SerializeObject(cookie), new CookieOptions());
            }
            else
            {
                //display the text for the double entry method
                ErrorMsg = MakeMsg(Handler.CheckForDoubleEntryName(Name) ? "Name already taken" : "Username already taken");
            }

        }

        //fucntion that is used to turn the password into an hashvalue
        public string HashVal(string pass)
        {
            //create a new password hasher and configure it for strings
            var passHasher = new PasswordHasher<string>();
            //return the new hashed password
            return pass = passHasher.HashPassword(null, pass);

        }
        //make a msg that will be displayed
        private string MakeMsg(string msg)
        {
            return msg;
        }
    }
}