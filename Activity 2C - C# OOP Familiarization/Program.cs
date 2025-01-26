using System.Threading;
using System;
using Activity_2C___C__OOP_Familiarization.Products;
using Activity_2C___C__OOP_Familiarization.Orders;

namespace Activity_2C___C__OOP_Familiarization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tshirt = new Product(1, "T-Shirt", 300);
            var jeans = new Product(2, "Jeans", 450);
            var shoes = new Product(3, "Shoes", 1500);

            Console.WriteLine("Welcome to Aesthehicc!\nToday's Promo: Get a 10% discount with a minimum total of P3000 or 5% discount with a minimum total of P2000!\n");

            Console.WriteLine("=================================================\nItems in Stock:");
            tshirt.DisplayProductDetails();
            jeans.DisplayProductDetails();
            shoes.DisplayProductDetails();
            Console.WriteLine("=================================================\n");

            var order = new Order(77);
            order.AddOrderItem(new OrderItem(tshirt, 5));
            order.AddOrderItem(new OrderItem(jeans, 2)); 
            order.AddOrderItem(new OrderItem(shoes, 1));

            Console.WriteLine("\n=================================================");
            Console.WriteLine("Order Details:");
            order.DisplayOrderDetails();

            Console.WriteLine($"=================================================\n\nTotal with Discount: P{order.Discount()}");
        }
    }
}
