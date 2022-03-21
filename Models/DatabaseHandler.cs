using System.Collections.Generic;
using Dapper;
using MySql.Data.MySqlClient;

namespace ProjectComicBook.Models
{
    public class DatabaseHandler
    {
        private MySqlConnection Connect()
        {
            return new MySqlConnection("SERVER=localhost;DATABASE=projectcomicbook;user=root;PASSWORD=;SSL Mode=None;");
        }

        public IEnumerable<dynamic> GetAllComicBooks()
        {
            using var connection = Connect();
            return connection.Query("SELECT * FROM comicbook");
        }
        
        public IEnumerable<dynamic> GetAllAuthors()
        {
            using var connection = Connect();
            return connection.Query("SELECT * FROM author");
        }

        public void DeleteAuthor(int authorID)
        {
            using var connection = Connect();
            connection.Execute("DELETE FROM author WHERE authorID = @authorID", new {authorID});
        }
        public void AddNewUser(string UserName, string Password)
        {
            using var connection = Connect();
            //var insert = ("Insert INTO user (@username, @password), VALUES (@0, @1)");
            var sqlinsert = "INSERT INTO user (username,password)" +"VALUES (@0,@1)";
            string querding = new string(UserName + "," + Password);
            connection.Execute(sqlinsert, querding);
            //connection.Execute(insert, "UserName", "Password");
            //connection.Execute("INSERT INTO user (username, password)", VALUES ("UserName", "Password"));

        }
    }
}