public class Product
{
    public string Name { get; set; }
    private double _price;
    private int _quantity;


    public double Price
    {
        get => _price;
        set
        {
            if (value < 0)
                throw new ArgumentException("Price must be a positive number", nameof(value));
            _price = value;
        }
    }

    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value < 0)
                throw new ArgumentException("Quantity can't be a negative number", nameof(value));
            _quantity = value;
        }
    }

    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}";
    }
}