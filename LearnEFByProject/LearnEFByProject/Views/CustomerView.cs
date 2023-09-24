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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login Done successfully");
                Console.ForegroundColor = ConsoleColor.Gray;
                return customer;
            }
        }

        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please enter valId ID");
        Console.ForegroundColor = color;
        MainView.Start();
        return null;
    }
    public static void Register()
    {
        Console.WriteLine("Welcome in Registration Page");
        Console.Write("Enter Your name : ");
        string name = Console.ReadLine();

        Console.Write("Enter Your phone Number : ");
        string phone = Console.ReadLine();

        CustomerController.Register(name, phone);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Customer Done Successfully");
        Console.ForegroundColor = ConsoleColor.Gray;
        MainView.Start();
    }
    public static void AllCustomersView()
    {
        var customers = CustomerController.AllCustomers();
        if (customers is null)
        {
            Console.WriteLine("No Customers in System Yet");
        }
        else
        {
            var color = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('-', 35));

            int Counter = 0;
            foreach (var customer in customers)
            {
                Counter++;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Customer " + Counter);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Customer ID : " + customer.Id);
                Console.WriteLine("Customer Name : " + customer.Name);
                Console.WriteLine("Customer Phone : " + customer.Phone);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('-', 35));
            Console.ForegroundColor = color;
        }
        MainView.Start();
    }
}