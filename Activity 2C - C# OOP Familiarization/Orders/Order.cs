using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2C___C__OOP_Familiarization.Orders
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderItem> OrderItems { get; private set; } = new List<OrderItem>();

        public Order(int oid)
        {
            OrderId = oid;
        }

        public void AddOrderItem(OrderItem item)
        {
            OrderItems.Add(item);
            Console.WriteLine($">>> Added {item.Product.Name} x{item.Quantity} to the order. <<<");
        }

        public decimal CalculateTotal()
        {
            return OrderItems.Sum(item => item.GetTotalPrice());
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine("Items:");
            foreach (var item in OrderItems)
            {
                item.DisplayOrderItemDetails();
            }
            Console.WriteLine($"Order Total: P{CalculateTotal()}");
        }
        public decimal Discount()
        {
            decimal total = CalculateTotal();

            decimal discount = 0;
            if (total >= 3000)
            {
                discount = 0.10m;
            }
            else if (total >= 2000)
            {
                discount = 0.05m;
            }

            decimal discountedTotal = total * (1 - discount);
            Console.WriteLine($"Discount Applied: {discount * 100}%");
            return discountedTotal;
        }
    }
}
