using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        var address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        var customer1 = new Customer("John Doe", address1);
        var customer2 = new Customer("Jane Smith", address2);

        var product1 = new Product("Laptop", "P001", 1000m, 1);
        var product2 = new Product("Mouse", "P002", 20m, 2);
        var product3 = new Product("Keyboard", "P003", 50m, 1);
        var product4 = new Product("Monitor", "P004", 300m, 1);

        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        var orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}\n");
        }
    }
}
