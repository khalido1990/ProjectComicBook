using System.Collections.Generic;
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

        public IEnumerable<dynamic> GetAllComicBooks()
        {
            using var connection = Connect();
            return connection.Query("SELECT * FROM comicbook");
        }
        
        public IEnumerable<dynamic> GetRecentlyAddedComicBooks()
        {
            using var connection = Connect();
            return connection.Query("SELECT * FROM comicbook JOIN author a on a.authorID = comicbook.authorID ORDER BY comicbookID DESC");
        }
        
        public IEnumerable<dynamic> GetAllAuthors()
        {
            using var connection = Connect();
            return connection.Query("SELECT * FROM author");
        }
        
        public IEnumerable<dynamic> GetAllIllustrators()
        {
            using var connection = Connect();
            return connection.Query("SELECT * FROM illustrator");
        }
        
        public void AddAuthor(string name, string description)
        {
            using var connection = Connect(); 
            connection.Execute("INSERT INTO author (name, description) values (@name, @description)"
                , new {name, description});
        }
        
        public void UpdateAuthor(int authorID, string name, string description)
        {
            using var connection = Connect();
            connection.Execute("UPDATE author SET name = @name, description = @description WHERE authorID = @authorID", new {authorID, name, description});
        }
        
        public void DeleteAuthor(int authorID)
        {
            using var connection = Connect();
            connection.Execute("UPDATE comicbook SET authorID = NULL WHERE authorID = @authorID;DELETE FROM author WHERE authorID = @authorID", new {authorID});
        }

        public void AddIllustrator(string name, string description)
        {
            using var connection = Connect(); 
            connection.Execute("INSERT INTO illustrator (name, description) values (@name, @description)"
                , new {name, description});
        }
        
        public void UpdateIllustrator(int illustratorID, string name, string description)
        {
            using var connection = Connect();
            connection.Execute("UPDATE illustrator SET name = @name, description = @description WHERE illustratorID = @illustratorID", new {illustratorID, name, description});
        }
        
        public void DeleteIllustrator(int illustratorID )
        {
            using var connection = Connect();
            connection.Execute("UPDATE comicbook SET illustratorID = NULL WHERE illustratorID = @illustratorID;DELETE FROM illustrator WHERE illustratorID = @illustratorID", new {illustratorID});
        }
        
        public void AddComic(int serie_ID, int authorID, int illustratorID, string title, string descriptionComic, string isbn, string releaseDate, string type, string pages)
        {
            using var connection = Connect();
            connection.Execute("INSERT INTO comicbook(serie_ID, authorID, illustratorID, title, description, isbn, release_date, type, pages) values (@serie_ID, @authorID, @illustratorID, @title, @descriptionComic, @isbn, @releaseDate, @type, @pages )" 
                , new {serie_ID, authorID, illustratorID, title, descriptionComic, isbn, releaseDate, type, pages});
        }
        
        public void UpdateComicbook(int comicbookID, int serie_ID, int authorID, int illustratorID, string title, string descriptionComic, string isbn, string releaseDate, string type, string pages, int explicitComic)
        {
            using var connection = Connect();
            connection.Execute("UPDATE comicbook SET comicbookID = @comicbookID, serie_ID = @serie_ID, titel = @title, release_date = @releaseDate, isbn = @isbn, type = @type, cover = NULL, description = @descriptionComic, pages = @pages, explicit = @explicitComic WHERE comicbookID = @comicbookID", new {comicbookID, serie_ID, authorID, illustratorID, title, releaseDate, isbn, type, descriptionComic, pages, explicitComic});
        }
        
        public void DeleteComicbook(int comicbookID)
        {
            using var connection = Connect();
            connection.Execute("DELETE FROM comicbook WHERE comicbookID = @comicbookID", new {comicbookID});
        }

        public IEnumerable<object> ViewCollection(int userID)
        {
            using var connection = Connect();
                return connection.Query("SELECT * FROM `collectioncomicbook` WHERE userID = @userID", new {userID});
        }
        
        public void AddToCollection(int comicbookID, int userID)
        {
            using var connection = Connect();
            connection.Execute("INSERT INTO collectioncomicbook (comicbookID, userID) values (@comicbookID, @userID)"
                , new {comicbookID, userID});
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
    }
}