namespace KolokwiumApp.Repositories;
using Models;

public interface IBookRepository
{
    public IEnumerable<Book> GetGenres(int id);
    public bool InsertBookIntoTable(BooksGenres booksGenres);

}