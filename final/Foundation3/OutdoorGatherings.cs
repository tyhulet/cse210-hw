public class OutdoorGatherings : Events
{
    private string _weatherType;

    public OutdoorGatherings(string eventTitle, string eventDesctiption, string eventDate, string eventTime, string eventAddress, string weatherType)
    : base(eventTitle, eventDesctiption, eventDate, eventTime, eventAddress)
    {
        _weatherType = weatherType;
    }

    public void DisplayWeather()
    {
        Console.WriteLine($"Events Weather: {_weatherType}");
    }
}