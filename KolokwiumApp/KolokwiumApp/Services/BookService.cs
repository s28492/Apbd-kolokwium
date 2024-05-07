using KolokwiumApp.Models;
namespace KolokwiumApp.Services;

public class BookService : IBookService
{
    private readonly IBookService _bookRepository;

    public BookService(IBookService bookService)
    {
        _bookRepository = bookService;
    }

    public IEnumerable<Book> GetBookGenres(int id)
    {
        
        return _bookRepository.GetBookGenres(id);
    }

    public string InsertBook(BooksGenres booksGenres)
    {
        
        return "";
    }

}