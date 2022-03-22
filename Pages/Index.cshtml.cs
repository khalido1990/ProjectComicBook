using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjectComicBook.Models;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public IEnumerable<dynamic> ComicBooks{ get; set; }
    public IEnumerable<dynamic> Authors{ get; set; }
    public IEnumerable<dynamic> Illustrators { get; set; }

    public void OnGet()
    {
        ComicBooks = new DatabaseHandler().GetAllComicBooks();
        Authors = new DatabaseHandler().GetAllAuthors();
        Illustrators = new DatabaseHandler().GetAllIllustrators();
    }
}