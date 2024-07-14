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

    public void AddProducts()
    {

    }

    public int TotalCost()
    {
        return TotalCost();
    }

    public string PackingInfo()
    {
        return PackingInfo();
    }

    public string ShippingInfo()
    {
        return ShippingInfo();
    }

    public string DisplayOrder()
    {
        return DisplayOrder();
    }
}