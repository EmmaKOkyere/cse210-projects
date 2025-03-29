using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating addresses  
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Creating customers  
        Customer customer1 = new Customer("John Micheals", address1);
        Customer customer2 = new Customer("Emmanuel Okyere", address2);

        // Creating products  
        Product product1 = new Product("Wireless Bluetooth", "ELEC-001", 10.00m, 2);
        Product product2 = new Product("Power Bank", "ELEC-005", 15.00m, 1);
        Product product3 = new Product("Solar-Powered LED lantern", "OUTDOOR-004", 7.50m, 3);

        // Creating orders  
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Displaying order details  
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }
}