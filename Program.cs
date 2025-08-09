using System;

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();
        while (true)
        {
            Console.WriteLine("\n--- Inventory Menu ---");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Product name: ");
                    string name = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(name))
                    {
                        Console.Write("Name cannot be empty. Please enter a valid product name: ");
                        name = Console.ReadLine();
                    }

                    Console.Write("Price: ");
                    if (!double.TryParse(Console.ReadLine(), out double price)) price = 0;

                    Console.Write("Quantity: ");
                    if (!int.TryParse(Console.ReadLine(), out int quantity)) quantity = 0;

                    try
                    {
                        inventory.AddProduct(name, price, quantity);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error adding product: {ex.Message}");
                    }
                    break;
                case "2":
                    inventory.ViewProducts();
                    break;
                case "3":
                    Console.Write("Enter the product name to update: ");
                    string updateName = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(updateName))
                    {
                        Console.WriteLine("Invalid product name.");
                        break;
                    }

                    Console.Write("New Name: ");
                    string newName = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(newName))
                    {
                        Console.Write("Name cannot be empty. Please enter a valid product name: ");
                        newName = Console.ReadLine();
                    }

                    Console.Write("New Price: ");
                    if (!double.TryParse(Console.ReadLine(), out double updatePrice)) updatePrice = 0;

                    Console.Write("New Quantity: ");
                    if (!int.TryParse(Console.ReadLine(), out int updateQuantity)) updateQuantity = 0;

                    try
                    {
                        inventory.UpdateProduct(updateName, newName, updatePrice, updateQuantity);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error updating product: {ex.Message}");
                    }
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}