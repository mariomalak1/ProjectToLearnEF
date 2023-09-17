using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LearnEFByProject.DataBase.Models;

public class Customer
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Phone { get; set; }

    public ICollection<Cart> Carts { get; set; } = null;
}