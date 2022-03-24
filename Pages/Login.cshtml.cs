using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySqlX.XDevAPI.Relational;
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
    public class Login : PageModel
    {
    
        [Required] [BindProperty] public string UserName { get; set; }
        [MaxLength]
        [Required] [BindProperty] public string Password { get; set; }
        [Required] [BindProperty] public string Name { get; set; }
        [TempData] public string Cpassword { get; set; }
        [TempData] public bool KeepLoggedIn { get; set; }
        [TempData] public bool IsLoggedIn { get; set; }
        
        public string ErrorMsg = "";
        private IDataProtectionProvider _provider = new EphemeralDataProtectionProvider();
        private DataProtection ProtectionString = new DataProtection();

        private readonly IDataProtector dataProtector;
        
        public DatabaseHandler Handler = new DatabaseHandler();

        public Login()
        {
            
            
        }
        
        public void OnGet()
        {
            
        }
        
        public void OnPostLogin(string UserName, string Password, bool KeepLoggedIn)
        {
            user me = Handler.GetUserNow(UserName, Password);
            if (me.username == UserName)
            {
                ErrorMsg = MakeMsg("Welcome" + " " + me.username);
            }
            else
            {
                ErrorMsg = MakeMsg("Wrong username or password");
                
            }
            
        }


        public void Setup()
        {
            if (Request.Cookies["Login"] != null)
            {
                
            }
        }

        public void OnPostReg(string UserName, string Password, string Name, string Cpassword)
        {
            if (Password == Cpassword)
            {
                Handler.AddNewUser(UserName, HashVal(Password), Name);
                ErrorMsg = MakeMsg("Welcome" + "" + Name);
            }
            else
            {
                ErrorMsg = MakeMsg("Password does not match");
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