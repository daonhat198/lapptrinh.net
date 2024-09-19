using System;

public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public Product(string name, decimal price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    public abstract void DisplayProductInfo();

    
    public abstract void ApplyDiscount(decimal percentage);
}


public interface ISellable
{
    void Sell(int quantity);
    bool IsInStock();
}

public class MobilePhone : Product, ISellable
{
    public MobilePhone(string name, decimal price, int stock)
        : base(name, price, stock) { }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Mobile Phone: {Name}, Price: {Price}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public void Sell(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} {Name}(s) sold.");
        }
        else
        {
            Console.WriteLine($"Insufficient stock to sell {quantity} {Name}(s).");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}

public class Laptop : Product, ISellable
{
    public Laptop(string name, decimal price, int stock)
        : base(name, price, stock) { }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Laptop: {Name}, Price: {Price}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public void Sell(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} {Name}(s) sold.");
        }
        else
        {
            Console.WriteLine($"Insufficient stock to sell {quantity} {Name}(s).");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}


public class Accessory : Product, ISellable
{
    public Accessory(string name, decimal price, int stock)
        : base(name, price, stock) { }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Accessory: {Name}, Price: {Price}, Stock: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public void Sell(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} {Name}(s) sold.");
        }
        else
        {
            Console.WriteLine($"Insufficient stock to sell {quantity} {Name}(s).");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        MobilePhone phone = new MobilePhone("IPhone 14 pro max", 40m, 10);
        Laptop laptop = new Laptop("Dell Imprison", 19m, 5);
        Accessory accessory = new Accessory("Mouse", 3m, 20);


        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();

        
        phone.Sell(3);
        laptop.Sell(2);
        accessory.Sell(5);

        
        Console.WriteLine($"Phone con ton kho: {phone.IsInStock()}");
        Console.WriteLine($"Laptop con ton kho: {laptop.IsInStock()}");
        Console.WriteLine($"Accessory con ton kho: {accessory.IsInStock()}");

        
        phone.ApplyDiscount(10);
        laptop.ApplyDiscount(15);
        accessory.ApplyDiscount(5);


        Console.WriteLine("\nAfter discount:");
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();
    }
}
