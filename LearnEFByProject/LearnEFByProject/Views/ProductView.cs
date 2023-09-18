using LearnEFByProject.DataBase.Models;
using Microsoft.IdentityModel.Tokens;

namespace LearnEFByProject.Views;

public class ProductView
{
    public static void AllProducts(Customer customer)
    {
        
    }
    
    public static void AddProduct(Customer customer)
    {
        Console.WriteLine("Welcome in add product page");
        Console.Write("Enter Name of Product : ");
        string name = Console.ReadLine();
        Console.Write("Enter Price of Product : ");
        string price = Console.ReadLine();

        if (! string.IsNullOrWhiteSpace(name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please Enter valid Name"); 
            Console.ForegroundColor = ConsoleColor.Gray;
            MainView.AfterLoginView(customer);
            return;
        }
        if (MainView.isNumiric(price) == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please Enter valid Price"); 
            Console.ForegroundColor = ConsoleColor.Gray;
            MainView.AfterLoginView(customer);
            return;
        }
        
        
    }
    
}