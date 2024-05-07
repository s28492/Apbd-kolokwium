using KolokwiumApp.Models;
using Microsoft.Data.SqlClient;
namespace KolokwiumApp.Repositories;

public class BookRepository: IBookRepository
{
    private IConfiguration _configuration;

    public BookRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IEnumerable<Book> GetGenres(int id)
    {
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        
        using var cmd = new SqlCommand("Select books.pk, books.title, genres.name From books INNER JOIN books_genres ON books.PK = books_genres.FK_book  INNER JOIN genres ON books_genres.FK_genre = genres.PK WHERE books.PK = @id", con);
        cmd.Parameters.AddWithValue("@id", id);
        using var dr = cmd.ExecuteReader();
        var books = new List<Models.Book>();
        IEnumerable<Book> genres = new List<Book>();
        
        while (dr.Read())
        {
            books.Add(new Book
            {
                id = (int)dr["pk"],
                Title =  (string)dr["title"],
                Genre = (string)dr["name"]
            });
        }
        return books;
    }

    public bool InsertBookIntoTable(BooksGenres booksGenres)
    {
        
        /*
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
    
        using var tran = con.BeginTransaction();

        using var cmd = new SqlCommand("INSERT INTO books VALUES (@title); INSERT INTO genres VALUES (@genre);",
            con);
        cmd.Parameters.AddWithValue("@title", booksGenres.Title);
        cmd.Parameters.AddWithValue("@genre", booksGenres.Genre);
        
        cmd.ExecuteNonQuery();
        */

        return true;
    

    }
}