﻿using System.Collections.Generic;
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
        
        public void AddAuthor(string name, string description)
        {
            using var connection = Connect(); 
            connection.Execute("INSERT INTO author (name, description) values (@name, @description)"
                , new {name, description});
        }
    }
}