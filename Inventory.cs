using System;
using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    private List<Product> products = new List<Product>();
    public void AddProduct(string name, double price, int quantity)
    {
        products.Add(new Product(name, price, quantity));
        Console.WriteLine("Product was added :)");
    }

    public void ViewProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        Console.WriteLine("\n--- Product List ---");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}