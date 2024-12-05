namespace ConsoleApp6;
public class Product // Task 1
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Product()
    {
        this.Name = "Unknown";
        this.Price = 0;
        this.Quantity = 0;
    }

    public Product(string name, decimal price, int quantity)
    {
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    public decimal CalculateTotalCost()
    {
        return Price * Quantity;
    }
}

public static class Task1Product
{
    public static void Run()
    {
        Console.WriteLine("Enter product name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter product price:");
        decimal price;
        while (!decimal.TryParse(Console.ReadLine(), out price) || price < 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive decimal value for the price:");
        }

        Console.WriteLine("Enter product quantity:");
        int quantity;
        while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer for the quantity:");
        }

        var product = new Product(name, price, quantity);
        Console.WriteLine($"Product: {product.Name}, Total Cost: {product.CalculateTotalCost()}");
    }
}

