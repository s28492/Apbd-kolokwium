using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace KolokwiumApp.Models;

public class Book
{
    [Key]
    [Required]
    public int id { get; set; }

    [Required]
    public string Title { get; set; }
    
    [Required]
    public string Genre{ get; set; }
    
}