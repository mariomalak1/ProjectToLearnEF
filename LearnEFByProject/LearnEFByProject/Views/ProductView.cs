using LearnEFByProject.Controllers;
using LearnEFByProject.DataBase.Models;


namespace LearnEFByProject.Views;

public class ProductView
{
    public static void AllProducts(Customer customer)
    {
        var products = ProductController.AllProducts();
        if (products == null)
        {
            Console.WriteLine("No Create Yet");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('-', 35));

            int Counter = 0;
            foreach (var product in products)
            {
                Counter++;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Product " + Counter);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Product ID : " + product.Id);
                Console.WriteLine("Product Name : " + product.Name);
                Console.WriteLine("Product Price : " + product.Price);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('-', 35));
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    
    public static void AddProduct(Customer customer)
    {
        Console.WriteLine("Welcome in add product page");
        Console.Write("Enter Name of Product : ");
        string name = Console.ReadLine();

        Console.Write("Enter Price of Product : ");
        string price = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please Enter valid Name"); 
            Console.ForegroundColor = ConsoleColor.Gray;
            MainView.AfterLoginView(customer);
            return;
        }

        int priceInt = MainView.isNumiric(price);
        if (priceInt == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please Enter valid Price"); 
            Console.ForegroundColor = ConsoleColor.Gray;
            MainView.AfterLoginView(customer);
            return;
        }

        ProductController.AddProduct(name, priceInt);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Product Created Successfully");
        Console.ForegroundColor = ConsoleColor.Gray;
        MainView.AfterLoginView(customer);
    }
}