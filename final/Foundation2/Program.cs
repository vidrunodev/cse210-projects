using System;
using System.Collections.Generic;

namespace EncapsulationWithOnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
            Customer customer1 = new Customer("John Doe", address1);

            List<Product> products1 = new List<Product>()
            {
                new Product("Laptop", "LT123", 500, 1),
                new Product("Headphones", "HP456", 50, 1)
            };
            Order order1 = new Order(products1, customer1);

            Console.WriteLine("Order Details:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        }
    }
}
