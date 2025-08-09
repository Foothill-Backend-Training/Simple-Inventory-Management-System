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

    public void UpdateProduct(string name, string newName, double newPrice, int newQuantity)
    {
        var product = products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (product == null)
        {
            throw new ArgumentException("Product not found", nameof(name));
        }

        product.Update(newName, newPrice, newQuantity);
        Console.WriteLine("Product was updated :)");
    }

    public void DeleteProduct(string deleteName)
    {
        var product = products.FirstOrDefault(p => p.Name.Equals(deleteName, StringComparison.OrdinalIgnoreCase));
        if (product == null)
        {
            throw new ArgumentException("Product not found", nameof(deleteName));
        }

        products.Remove(product);
        Console.WriteLine("Product was deleted :)");
    }
}