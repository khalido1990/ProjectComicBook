using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

//hier staan voorbeelden van de commandos van de CookieInfo static
namespace ProjectComicBook.Pages
{
    
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

            //check if the shared info hasvalid data bool is 
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
    }
}