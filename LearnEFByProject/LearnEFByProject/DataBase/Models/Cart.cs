namespace LearnEFByProject.DataBase.Models;

public class Cart
{
    public int Id { get; set; }

    public ICollection<Order> Orders { get; set; } = null;

    public Customer Customer { get; set; } = null;
    
    public int CustomerId { get; set; }

    public bool Finished { get; set; }
}
