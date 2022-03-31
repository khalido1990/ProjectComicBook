using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using ProjectComicBook.Pages;
using Microsoft.AspNetCore.Identity;

namespace ProjectComicBook.Models
{
    public class DatabaseHandler
    {
        private MySqlConnection Connect()
        {
            return new MySqlConnection("SERVER=localhost;DATABASE=projectcomicbook;user=root;PASSWORD=;SSL Mode=None;");
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
                    new {userName, Name}).Single();
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
        
        public IEnumerable<object> ViewCollection(int userID)
        {
            using var connection = Connect();
            return connection.Query(
                "SELECT collectioncomicbook.userID, collectioncomicbook.comicbookID, comicbook.title, comicbook.cover FROM collectioncomicbook INNER JOIN comicbook ON collectioncomicbook.comicbookID=comicbook.comicbookID WHERE collectioncomicbook.userID=@userID",
                new {userID});
        }

        public void AddToCollection(int comicbookID, int userID)
        {
            using var connection = Connect();
            //connection.Execute("SELECT comicbookID, userID FROM collectioncomicbook where userID = @userID AND comicbookID = @comicbookID",
            //    new {comicbookID, userID});
            connection.Execute("INSERT INTO collectioncomicbook (comicbookID, userID) values (@comicbookID, @userID)"
                , new {comicbookID, userID});
        }
        
        public IEnumerable<object> RemoveFromCollection(int comicbookID, int userID)
        {
            using var connection = Connect();
            return connection.Query(
                "DELETE FROM collectioncomicbook WHERE comicbookID = @comicbookID AND userID = @userID",
                new {comicbookID, userID});
        }

        //public void CollectionCheck(int comicbookID, int userID)
        //{
        //    using var connection = Connect();
        //    connection.Execute("SELECT comicbookID, userID FROM collectioncomicbook where userID = @userID AND comicbookID = @comicbookID",
        //        new {comicbookID, userID});
        //}
    }
}