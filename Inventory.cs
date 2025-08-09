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
}