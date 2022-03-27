using System.Collections.Generic;
using Dapper;
using Microsoft.AspNetCore.Identity;
using MySql.Data.MySqlClient;
using ProjectComicBook.Pages;

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
        public void AddAuthor(string name, string description)
        {
            using var connection = Connect(); 
            connection.Execute("INSERT INTO author (name, description) values (@name, @description)"
                , new {name, description});
        }
        public void AddNewUser(string username, string password, string name)
        {
            int role_ID = 3;
            using var connection = Connect();
            //var insert = ("Insert INTO user (@username, @password), VALUES (@0, @1)");
            connection.Execute("INSERT INTO user (username,password, name, role_ID)" +"VALUES (@username,@password, @name, @role_ID)", 
                new {username, password, name, role_ID});
        }

        public bool CheckForDoubleEntryUserName(string userName)
        {
            using var connection = Connect();
            try
            {
                connection.Query(
                    "SELECT * FROM user WHERE username=@userName",
                    new {userName});
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
            
        }
        public bool CheckForDoubleEntryName(string Name)
        {
            using var connection = Connect();
            try
            {
                connection.Query(
                    "SELECT * FROM user WHERE name=@Name",
                    new {Name}).Single();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
            
        }
        
        public bool CheckForDoubleEntry(string userName, string Name)
        {
            using var connection = Connect();
            try
            {
                connection.Query(
                    "SELECT * FROM user WHERE username=@userName or name=@Name",
                    new {userName, Name});
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
            
        }
        public user GetUserNow(string username, string password)
        {
            var passwordhasher = new PasswordHasher<string>();
            user _user = new user();
            using var connection = Connect();
            try
            {
                _user = connection.Query<user>(
                    "SELECT * FROM user WHERE username=@username",
                    new {username}).Single();
                if (passwordhasher.VerifyHashedPassword(null, _user.password, password) ==
                    PasswordVerificationResult.Success)
                {
                    return _user;
                }

            }
            catch (Exception e)
            {
                return new user();
            }

            return new user();

        }
    }
}