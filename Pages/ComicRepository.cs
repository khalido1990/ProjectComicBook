using System.Data;
using Dapper;
using MySql.Data.MySqlClient;


namespace ProjectComicBook.Pages;

public class ComicRepository
{
    private MySqlConnection Connect()
    {
        return new MySqlConnection("SERVER=localhost;DATABASE=projectcomicbook;user=root;PASSWORD=;SSL Mode=None;");
    }
    
    public List<Comic> Search(string search)
    {
        using var connection = Connect();
        var comic = connection.Query<Comic>("SELECT * FROM comicbook WHERE titel LIKE @search OR description LIKE @search", new
        {
            search = "%" + search + "%"
        });
        return comic.ToList();
    }
}