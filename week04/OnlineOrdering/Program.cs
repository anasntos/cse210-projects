using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // First Order
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Notebook", "N001", 4.50f, 3),
            new Product("Pen", "P001", 1.25f, 10)
        };
        Order order1 = new Order(products1, customer1);

        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Second Order
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Mark Benson", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("Water Bottle", "W001", 10.00f, 2),
            new Product("Backpack", "B001", 45.99f, 1),
            new Product("Notebook", "N002", 4.50f, 5)
        };
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
