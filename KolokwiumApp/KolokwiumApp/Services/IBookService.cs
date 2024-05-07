namespace KolokwiumApp.Services;
using Models;

public interface IBookService
{
    public IEnumerable<Book> GetBookGenres(int id);
    public string InsertBook(BooksGenres booksGenres);
}