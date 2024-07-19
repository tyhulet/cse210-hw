using System.Runtime.CompilerServices;

public class Address
{
    private string _streetAddress;
    private string _cityName;
    private string _state;
    private string _country;

    public Address(string streetAddress, string cityName, string state, string country)
    {
        _streetAddress = streetAddress;
        _cityName = cityName;
        _state = state;
        _country = country;
    }

    public bool OutsideUsa()
    {
        return _country == "usa";
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_streetAddress}, {_cityName}, {_state}, {_country}");
    }
}