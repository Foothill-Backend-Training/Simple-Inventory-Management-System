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
            Console.WriteLine("2. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Product name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    if (!double.TryParse(Console.ReadLine(), out double price)) price = 0;

                    Console.Write("Quantity: ");
                    if (!int.TryParse(Console.ReadLine(), out int quantity)) quantity = 0;

                    inventory.AddProduct(name, price, quantity);
                    break;
                case "2":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}