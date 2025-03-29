// This program simulates an online ordering system with classes for Address, Customer, Product, and Order.
// It creates instances of these classes, adds products to orders, and displays packing and shipping labels along with the total cost of each order.
using System;

class Program
{
    static void Main(string[] args)
    {
         Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("548 Maple Ave", "Toronto", "ON", "Canada");

        // Create customer objects with their respective addresses
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create product objects with their respective details
        Product product1 = new Product("Laptop", 101, 800m, 1);
        Product product2 = new Product("Phone", 102, 400m, 2);
        Product product3 = new Product("Headphones", 103, 150m, 3);

        // Create order objects with the products and customers
        List<Product> order1Products = new List<Product> { product1, product2 }; 
        List<Product> order2Products = new List<Product> { product2, product3 }; 

        Order order1 = new Order(order1Products, customer1);
        Order order2 = new Order(order2Products, customer2);

        // Display packing and shipping labels for each order
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel()); 
        Console.WriteLine(order1.GetShippingLabel()); 
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}"); 
        Console.WriteLine();

        // Display packing and shipping labels for the second order
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());  
        Console.WriteLine(order2.GetShippingLabel()); 
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}