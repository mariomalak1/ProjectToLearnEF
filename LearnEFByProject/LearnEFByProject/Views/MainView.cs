using LearnEFByProject.DataBase.Models;

namespace LearnEFByProject.Views;

public class MainView
{
    public static int isNumiric(string str){
    try{
        int num = Convert.ToInt32(str);
        return num;
    }
    catch (Exception e)
    {
        return 0;
    }
}
    public static void redirect(string response)
    {
        if (response == "1")
        {
            CustomerView.Register();
        }
        
        else if (response == "2")
        {
            var customer = CustomerView.Login();
            AfterLoginView(customer);
        }

        else if (response == "3")
        {
            CustomerView.AllCustomersView();
        }
        
        else
        {
            // to print the message in red
            // save the color of the console right now 
            // change color
            // create your output, then change the color again
            
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Please enter valid response 1 or 2 only");
            Console.ForegroundColor = originalColor;
            
            // to go to the first page
            Start();
        }
    }
    public static void Start()
    {
        string response = "";
        Console.WriteLine("Main Page");
        Console.WriteLine("Select one Option From All of this options");
        Console.WriteLine("1- create new customer");
        Console.WriteLine("2- Login with customer id");
        Console.WriteLine("3- Show all customers in system");
        Console.Write("What's Your response : ");
        
        response = Console.ReadLine();

        redirect(response);
    }

    public static void AfterLoginView(Customer customer)
    {
        Console.WriteLine("Choose from this menu : ");
        Console.WriteLine("1-Add New Order");
        Console.WriteLine("2-Add New Product");
        Console.WriteLine("3-View All Products");
        Console.WriteLine("4-Finish The Cart");
        Console.WriteLine("5-Logout");
        Console.Write("What's your response : ");
        string Response = Console.ReadLine();
        AfterLoginRedirect(Response, customer);
    }

    public static Customer AfterLoginRedirect(string res, Customer customer)
    {
        if (res == "1")
        {
            OrderView.AddOrder(customer);
        }
        else if (res == "2")
        {
            ProductView.AddProduct(customer);
        }
        else if (res == "3")
        {
            ProductView.AllProducts(customer);
        }
        else if (res == "4")
        {
            // finish the cart
        }
        else if(res == "5")
        {
            // logout
            Start();
            return null;
        }
        else
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter valid response");
            Console.ForegroundColor = color;
            AfterLoginView(customer);
            return null;
        }
        return customer;
    }
}