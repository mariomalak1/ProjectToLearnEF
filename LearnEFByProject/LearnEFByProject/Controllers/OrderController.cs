using LearnEFByProject.DataBase.Models;

namespace LearnEFByProject.Controllers;

public class OrderController
{
    public static Order AddOrder(int productID, Customer customer)
    {
        using (var database = new DataBase.DataBaseContext())
        {
            Console.WriteLine($"Customer Name : {customer.Name}");

            Cart cart = database.Cart.Where(a => (a.Customer == customer) && (a.Finished == false)).FirstOrDefault();

            Console.WriteLine($"Is Cart Or Null True Or False ? : {cart is null}");

            if (cart == null)
            {
                Console.WriteLine("Create New Cart");
                cart = new Cart() { Finished = false };
                database.Cart.Add(cart);
                cart.Customer = customer; cart.CustomerId = customer.Id;
                database.SaveChanges();
            }

            Console.WriteLine($"Cart ID : {cart.Id}, Cart Customer Name : {cart.Customer.Name} ");

            // get the product
            Product product = database.Product.Where(p => p.Id == productID).FirstOrDefault();

            // if product not found return to Mainview
            if (product == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No Product Found With This ID");
                Console.ForegroundColor = ConsoleColor.Gray;
                return null;
            }

            Console.WriteLine($"Product Detials -> Name : {product.Name}, ID : {product.Id}");
            Console.WriteLine($"Cart Detials -> Customer Name : {cart.Customer.Name}, ID : {cart.Id}, Finished : {cart.Finished}");

            Order order = new Order() { Cart = cart, Product = product};
            database.Orders.Add(order);
            
            database.SaveChanges();

            Console.WriteLine($"Order Detials -> ID : {order.Id}, Cart ID Of Order : {order.Cart.Id}, Cart is Finished Or Not : {order.Cart.Finished}");

            return order;
        }
    }
}