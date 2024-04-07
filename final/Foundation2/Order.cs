using System;
using System.Collections.Generic;

namespace EncapsulationWithOnlineOrdering
{
    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(List<Product> products, Customer customer)
        {
            this.products = products;
            this.customer = customer;
        }

        public double CalculateTotalCost()
        {
            double totalCost = 0;
            foreach (Product product in products)
            {
                totalCost += product.Price * product.Quantity;
            }
            if (customer.IsInUSA())
            {
                totalCost += 5; // Shipping cost for USA
            }
            else
            {
                totalCost += 35; // Shipping cost for non-USA
            }
            return totalCost;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "Packing Label:\n";
            foreach (Product product in products)
            {
                packingLabel += $"Product: {product.Name}, ID: {product.ProductId}\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            string shippingLabel = "Shipping Label:\n";
            shippingLabel += $"{customer.Name}\n";
            shippingLabel += $"{customer.Address.GetAddressString()}\n";
            return shippingLabel;
        }
    }
}
