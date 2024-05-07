using System.ComponentModel.DataAnnotations;

namespace KolokwiumApp.Models;

public class BooksGenres
{
    [Required]
    public string Title { get; set; }
    
    [Required]
    public IEnumerable<string> Genre{ get; set; }

}