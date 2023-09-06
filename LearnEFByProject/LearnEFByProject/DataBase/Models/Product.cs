using System.ComponentModel.DataAnnotations;

namespace LearnEFByProject.DataBase.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    public double Price { get; set; }

    [Required]
    public string Name { get; set; }
}