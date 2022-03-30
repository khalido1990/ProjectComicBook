using System.Collections.Generic;
using Dapper;
using MySql.Data.MySqlClient;
using ProjectComicBook.Models;

namespace ProjectComicBook.Repositories
{
    public class AuthorRepository
    {
        private MySqlConnection Connect()
        {
            return new MySqlConnection("SERVER=localhost;DATABASE=projectcomicbook;user=root;PASSWORD=;SSL Mode=None;");
        }
        
        public IEnumerable<Author> GetAllAuthors()
        {
            using var connection = Connect();
            return connection.Query<Author>("SELECT * FROM author");
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
    }
}