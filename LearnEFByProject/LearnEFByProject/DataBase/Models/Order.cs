namespace LearnEFByProject.DataBase.Models;

public class Order
{
    public int Id { get; set; }

    public Cart Cart { get; set; }

    public Product Product { get; set; }

    public int CartId { get; set; }
    
    public int ProductId { get; set; }
}