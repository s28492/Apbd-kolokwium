using System.ComponentModel.DataAnnotations;

namespace KolokwiumApp.Models;

public class Genres
{
    [Key]
    [Required]
    public int PrimaryKey { get; set; }

    [Required]
    public int Nam { get; set; }
    

    
}