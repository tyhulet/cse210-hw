using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

public class Orders
{
    private List<Products> _products = new List<Products>();
    private Customer _customers;


    public Orders(Customer customer)
    {
        _customers = customer;
    }

    public void AddProducts(Products products)
    {
        _products.Add(products);
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (Products products in _products)
        {
            total += products.CalculateCost();
        }

        double shippingCost;
        if (_customers.OutsideUsa())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        total += shippingCost;
        return total;
    }

    public void PackingInfo()
    {
        Console.WriteLine("Packing Label:");
        foreach (Products products in _products)
        {
            products.ShowProductInfo();
        }
    }

    public void ShippingInfo()
    {
        Console.WriteLine($"{_customers}: {_customers.DisplayCustomerInfo}");
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Shipping Label: {_customers.DisplayCustomerInfo()}, {_customers.ShowCustomerAddress}");
        double totalcost = TotalCost();
        Console.WriteLine($"Total Cost: {totalcost}");
    }
}