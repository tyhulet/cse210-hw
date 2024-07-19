using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===========================================");
        Address address1 = new Address("997 Deer Farm Rd", "Oberlin", "Louisiana(LA)", "USA");
        Customer customer1 = new Customer("Chad Walker", address1);
        Products products1 = new Products("Block of Cheese", "007JB", 8.99, 2);
        Products products2 = new Products("Air Mattress", "27HT8", 15.50, 1);

        Console.WriteLine("Order Number 1:");
        Orders order1 = new Orders(customer1);
        order1.AddProducts(products1);
        order1.AddProducts(products2);
        order1.PackingInfo();
        order1.DisplayOrder();

        Console.WriteLine("===========================================");
        Address address2 = new Address("47 Delan Road", "Drinan", "Queensland", "AU");
        Customer customer2 = new Customer("Asher Burton", address2);
        Products products3 = new Products("32 inch TV", "47BA7P", 299.99, 2);
        Products products4 = new Products("Bug Spray", "518ABC", 12.85, 5);

        Console.WriteLine("Order Number 2:");
        Orders order2 = new Orders(customer2);
        order2.AddProducts(products3);
        order2.AddProducts(products4);
        order2.PackingInfo();
        order2.DisplayOrder();

    }
}