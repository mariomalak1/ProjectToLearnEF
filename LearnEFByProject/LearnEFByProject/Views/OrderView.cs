using LearnEFByProject.DataBase.Models;

namespace LearnEFByProject.Views;

public class OrderView
{
    public static void AddOrder(Customer customer)
    {
        Console.WriteLine("Welcome in Add Order Page");
        Console.Write("Enter id of product you want to order it : ");
        string res = Console.ReadLine();
    }
}