using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySqlX.XDevAPI.Relational;
using ProjectComicBook.Models;

namespace ProjectComicBook.Pages
{
    public class Login : PageModel
    {
    
        [Required] [BindProperty] public string UserName { get; set; }
        [Required] [BindProperty] public string Password { get; set; }
        public DatabaseHandler Handler = new DatabaseHandler();
        
        public void OnGet()
        {
            
        }

        public void OnPostLogin(string UserName, string Password)
        {
            
        }

        public void OnPostReg(string UserName, string Password)
        {
            Handler.AddNewUser(UserName, Password);
        }


    }
}