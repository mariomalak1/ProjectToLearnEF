using LearnEFByProject.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnEFByProject.Controllers
{
    internal class CartController
    {
        public static bool FinishCart(Customer customer)
        {
            using (var db = new DataBase.DataBaseContext())
            {
                Cart cart = db.Cart.Where(c => c.Customer == customer && c.Finished == false).FirstOrDefault();
                if (cart is null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Haven't any orders yet");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return false;
                }
                cart.Finished = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cart Finished Successfully");
                Console.ForegroundColor = ConsoleColor.Gray;
                db.SaveChanges();
                return true;
            }
        }

        public static ICollection<Order>? OrdersInCart(Customer customer)
        {
            using (var db = new DataBase.DataBaseContext())
            {
                var cart = HasUnFinishedCart(customer);

                if (cart is null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Haven't any orders yet");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return null;
                }

                foreach (var order in cart.Orders)
                {
                    order.Product = db.Product.Where(p => p.Id == order.ProductId).FirstOrDefault();

                }
                return cart.Orders;
            }
        }

        public static Cart HasUnFinishedCart(Customer customer)
        {
            using (var db = new DataBase.DataBaseContext())
            {
                return db.Cart.Where(c => c.Customer == customer && c.Finished == false).Include(ca => ca.Orders).FirstOrDefault();
            }
        }
    }
}
