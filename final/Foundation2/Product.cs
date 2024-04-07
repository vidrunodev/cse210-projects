// Product.cs

using System;

public class Product
{
    // Properties
    public string Name { get; set; }
    public string ProductId { get; set; }
    public double Price { get; set; } // Added Price property
    public int Quantity { get; set; } // Added Quantity property

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price; // Initialize Price property
        Quantity = quantity; // Initialize Quantity property
    }

    // Method to calculate total cost of the product
    public double CalculateProductCost()
    {
        return Price * Quantity;
    }
}
