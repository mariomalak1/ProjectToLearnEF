namespace LearnEFByProject.Controllers;

using DataBase.Models;
public class CustomerController
{ 
    public static Customer Login(int id)
    {
        try
        {
            using (var database = new DataBase.DataBaseContext())
            {
                var customer = database.Customers.Find(id);
                return customer;
            }
        }
        catch (Exception e)
        {
            return null;
        }
    }
    public static Customer Register(string name = "", string phone = "")
    {
        using (var database = new DataBase.DataBaseContext())
        {
            var customer = new Customer(name, phone);
            database.Customers.Add(customer);
            database.SaveChanges();
            return customer;
        }
    }

    public static ICollection<Customer> AllCustomers()
    {
        try
        {
            using (var database = new DataBase.DataBaseContext())
            {
                return database.Customers.ToList();
            }
        }
        catch (Exception e)
        {
            return new List<Customer>();
        }
    }
}