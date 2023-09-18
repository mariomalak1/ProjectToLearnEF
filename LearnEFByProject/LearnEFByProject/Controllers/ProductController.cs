using LearnEFByProject.DataBase.Models;

namespace LearnEFByProject.Controllers;

public class ProductController
{
    public static Product AddProduct(string name, int price)
    {
        using (var database = new DataBase.DataBaseContext())
        {
            Product product = new Product(){
                Name = name,
                Price = price
            };
            database.Product.Add(product);
            database.SaveChanges();
            return product;
        }
    }
}