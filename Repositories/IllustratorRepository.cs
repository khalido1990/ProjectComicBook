using System.Collections.Generic;
using Dapper;
using MySql.Data.MySqlClient;
using ProjectComicBook.Models;

namespace ProjectComicBook.Repositories
{
    public class IllustratorRepository
    {
        private MySqlConnection Connect()
        {
            return new MySqlConnection("SERVER=localhost;DATABASE=projectcomicbook;user=root;PASSWORD=;SSL Mode=None;");
        }

        public IEnumerable<Illustrator> GetAllIllustrators()
        {
            using var connection = Connect();
            return connection.Query<Illustrator>("SELECT * FROM illustrator");
        }

        public void AddIllustrator(string name, string description)
        {
            using var connection = Connect();
            connection.Execute("INSERT INTO illustrator (name, description) values (@name, @description)"
                , new { name, description });
        }

        public void UpdateIllustrator(int illustratorID, string name, string description)
        {
            using var connection = Connect();
            connection.Execute("UPDATE illustrator SET name = @name, description = @description WHERE illustratorID = @illustratorID", new { illustratorID, name, description });
        }

        public void DeleteIllustrator(int illustratorID)
        {
            using var connection = Connect();
            connection.Execute("UPDATE comicbook SET illustratorID = NULL WHERE illustratorID = @illustratorID;DELETE FROM illustrator WHERE illustratorID = @illustratorID", new { illustratorID });
        }
    }
}