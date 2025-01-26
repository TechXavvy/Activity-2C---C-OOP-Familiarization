using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2C___C__OOP_Familiarization.Products
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int pid, string name, decimal price)
        {
            ProductId = pid;
            Name = name;
            Price = price;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductId}, Name: {Name}, Price: P{Price}");
        }   
    }
}
