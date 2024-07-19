public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string Name, Address address)
    {
        _customerName = Name;
        _customerAddress = address;
    }

    public bool OutsideUsa()
    {
        return _customerAddress.OutsideUsa();
    }

    public string DisplayCustomerInfo()
    {
        return $"{_customerName}";
    }

    public void ShowCustomerAddress()
    {
        Console.WriteLine($"{_customerAddress.DisplayAddress}");
    }
}
