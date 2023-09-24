using LearnEFByProject.DataBase.Models;

namespace LearnEFByProject.Views;

public class OrderView
{
    public static void AddOrder(Customer customer)
    {
        Console.WriteLine("Welcome in Add Order Page");
        Console.Write("Enter id of product you want to order it : ");
        string res = Console.ReadLine();
        int productID = MainView.isNumiric(res);
        if (productID == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please Enter Valid Product Id ");
            Console.ForegroundColor = ConsoleColor.Gray;
            
            MainView.AfterLoginView(customer);
        }
        else
        {
            Order order = Controllers.OrderController.AddOrder(productID, customer);
            if (order == null)
            {
                MainView.AfterLoginView(customer);
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Order is Done");
            Console.ForegroundColor = ConsoleColor.Gray;
            MainView.AfterLoginView(customer);
        }
    }
}