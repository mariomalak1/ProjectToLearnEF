using LearnEFByProject.DataBase.Models;
using LearnEFByProject.Views;

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

    public static ICollection<Product> AllProducts()
    {
        try
        {
            using (var database = new DataBase.DataBaseContext())
            {
                List<Product> products = database.Product.ToList();

                return products;
            }
        }
        catch (Exception e)
        {
            return null;
        }
    }
}