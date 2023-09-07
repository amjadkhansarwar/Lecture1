using System;

public class Product
{
    public string Name { set; get; }
    public int Quantity { set; get; }
    public double Price { set; get; }

    public Product(string name, int quantity, double price)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
    }

    public void PrintInfo()
    {
        Console.WriteLine($" Name : {Name}");
        Console.WriteLine($" Quantity : {Quantity}");
        Console.WriteLine($" Price : {Price}");
    }
}