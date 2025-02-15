﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity_2C___C__OOP_Familiarization.Products;

namespace Activity_2C___C__OOP_Familiarization.Orders
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public OrderItem(Product prod, int quan)
        {
            if (quan < 0)
            {
                Console.WriteLine($"An item's quantity cannot be negative. System will set it to 0.");
                quan = 0;
            }
            
            Product = prod;
            Quantity = quan;
        }

        public decimal GetTotalPrice()
        {
            return Product.Price * Quantity;
        }

        public void DisplayOrderItemDetails()
        {
            Console.WriteLine($"--> Product: {Product.Name} || Quantity: {Quantity} || Total: P{GetTotalPrice()}");
        }
    }
}
