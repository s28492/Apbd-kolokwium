using KolokwiumApp.Models;
using KolokwiumApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace KolokwiumApp.Controllers;
[ApiController]
[Route("api/books")]
public class BookController : ControllerBase
{
    private IBookService _bookService;
    private ILogger<BookController> _logger;

    public BookController(IBookService bookService, ILogger<BookController> logger)
    {
        _bookService = bookService;
        _logger = logger;
    }

    [HttpGet("{id}/genres")]
    public IActionResult GetBookGenre(int id)
    {
        
        var book = _bookService.GetBookGenres(id);
        return Ok(book);
    }

    [HttpPut]
    public IActionResult InsertBook([FromBody] BooksGenres booksGenres)
    {

        var result = _bookService.InsertBook(booksGenres);

        return Ok(result);

    }


}