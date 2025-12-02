using System;
using System.ComponentModel.DataAnnotations;

class Program
{   
    public static void DisplayOrder(Order order)
    {
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Packing Lablel:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order.GetPrice()}");
    }

    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Spongebob Squarepants", new Address("124 Conch Street", "Bikini Bottom", "Pacific Ocean", "Marshall Islands"));
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product(1, "Snail Food", 10, 5));
        order1.AddProduct(new Product(2, "Mop", 25, 1));
        order1.AddProduct(new Product(3, "Milk", 3, 3));

        Customer customer2 = new Customer("John Doe", new Address("1234 Example St.", "Denver", "Colorado", "United States of America"));
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product(4, "Shaving Cream", 25, 4));
        order2.AddProduct(new Product(5, "Dog Kibble", 50, 2));
        order2.AddProduct(new Product(6, "Bleach Cleaner", 2, 1));

        // Display
        DisplayOrder(order1);
        DisplayOrder(order2);
    }
}