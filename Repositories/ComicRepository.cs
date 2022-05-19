using System.Collections.Generic;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using ProjectComicBook.Models;

namespace ProjectComicBook.Repositories
{
    public class ComicRepository
    {
        private MySqlConnection Connect()
        {
            return new MySqlConnection("SERVER=localhost;DATABASE=projectcomicbook;user=root;PASSWORD=;SSL Mode=None;");
        }

        public List<ComicBook> Search(string search)
        {
            using var connection = Connect();
            var comic = connection.Query<ComicBook>("SELECT * FROM comicbook WHERE title LIKE @search OR description LIKE @search", new
            {
                search = "%" + search + "%"
            });
            return comic.ToList();
        }

        public IEnumerable<ComicBook> GetAllComicBooks()
        {
            using var connection = Connect();
            return connection.Query<ComicBook>("SELECT *,release_date as releaseDate FROM comicbook ORDER BY title");
        }

        public IEnumerable<ComicBookAndAuthor>? GetRecentlyAddedComicBooks()
        {
            using var connection = Connect();
            return connection.Query<ComicBookAndAuthor>(
                "SELECT *,a.name as authorName FROM comicbook JOIN author a on a.authorID = comicbook.authorID ORDER BY comicbookID DESC LIMIT 5");
        }

        public void AddComic(int serie_ID, int authorID, int illustratorID, string title, string descriptionComic, string isbn, string releaseDate, string type, string pages)
        {
            using var connection = Connect();
            connection.Execute(
                "INSERT INTO comicbook(serie_ID, authorID, illustratorID, title, description, isbn, release_date, type, pages) values (@serie_ID, @authorID, @illustratorID, @title, @descriptionComic, @isbn, @releaseDate, @type, @pages )"
                , new
                {
                    serie_ID,
                    authorID,
                    illustratorID,
                    title,
                    descriptionComic,
                    isbn,
                    releaseDate,
                    type,
                    pages
                });
        }

        public void UpdateComicbook(int comicbookID, int serie_ID, int authorID, int illustratorID, string title, string descriptionComic, string isbn, string releaseDate, string type, string pages, int explicitComic)
        {
            using var connection = Connect();
            connection.Execute(
                "UPDATE comicbook SET comicbookID = @comicbookID, serie_ID = @serie_ID, title = @title, release_date = @releaseDate, isbn = @isbn, type = @type, cover = NULL, description = @descriptionComic, pages = @pages, explicit = @explicitComic WHERE comicbookID = @comicbookID",
                new
                {
                    comicbookID,
                    serie_ID,
                    authorID,
                    illustratorID,
                    title,
                    releaseDate,
                    isbn,
                    type,
                    descriptionComic,
                    pages,
                    explicitComic
                });
        }

        public void DeleteComicbook(int comicbookID)
        {
            using var connection = Connect();
            connection.Execute("DELETE FROM comicbook WHERE comicbookID = @comicbookID", new { comicbookID });
        }
    }
}