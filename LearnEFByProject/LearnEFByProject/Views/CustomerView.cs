using LearnEFByProject.Controllers;
using LearnEFByProject.DataBase.Models;

namespace LearnEFByProject.Views;

public class CustomerView
{
    public static Customer Login()
    { 
        string Id; 
        Console.Write("enter your id : "); 
        Id = Console.ReadLine();
        int numID = MainView.isNumiric(Id);
        if (numID != 0)
        {
            Customer customer = CustomerController.Login(numID);
            if (customer != null)
            {
                Console.WriteLine("Login Done successfully");
                return customer;
            }
        }
        Console.WriteLine("Please enter valId ID");
        MainView.Start();
        return null;
    }
    
    public static Customer Register()
    {
        return new Customer();
    }
}