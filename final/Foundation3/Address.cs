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

    public string DisplayAddress()
    {
        return $"{_streetAddress}, {_cityName}, {_state}, {_country}";
    }
}