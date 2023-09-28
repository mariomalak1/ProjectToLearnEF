using LearnEFByProject.Controllers;
using LearnEFByProject.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEFByProject.Views
{
    internal class CartView
    {
        public static void ViewAllOrdersInCart(Customer customer) 
        { 
            var orders = CartController.OrdersInCart(customer);

            if (orders is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No Orders Created Yet");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }

            int Counter = 0;
            foreach (var order in orders) 
            {
                Counter++;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Order " + Counter);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Order ID : " + order.Id);
                Console.WriteLine("Order Product : " + order.Product.Name);
            }
        }
    }
}
