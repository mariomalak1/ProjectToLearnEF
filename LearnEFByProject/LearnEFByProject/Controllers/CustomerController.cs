namespace LearnEFByProject.Controllers;

using DataBase.Models;

public class CustomerController
{
    private static DataBase.DataBaseContext connection;
        
    public static Customer Login(int id)
    {
        var customer = connection.Customers.Find(id);
        if (customer != null)
        {
            return customer;
        }
        return null;
    }
}