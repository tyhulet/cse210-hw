public class Events
{
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private string _eventAddress;

    public Events(string eventTitle, string eventDesctiption, string eventDate, string eventTime, string eventAddress)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDesctiption;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
    }

    public void DisplayShortDetails()
    {
        Console.WriteLine($"Event Title: {_eventTitle}");
        Console.WriteLine($"Date of Event: {_eventDate}");
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Event Title: {_eventTitle}");
        Console.WriteLine($"Desctiption: {_eventDescription}");
        Console.WriteLine($"Date of Event: {_eventDate}");
        Console.WriteLine($"Time of Event: {_eventTime}");
        Console.WriteLine($"Address: {_eventAddress}");
    }

    public void DisplayFullDetails(string type)
    {
        Console.WriteLine($"Type of Event: {type}");
        Console.WriteLine($"Event Title: {_eventTitle}");
        Console.WriteLine($"Desctiption: {_eventDescription}");
        Console.WriteLine($"Date of Event: {_eventDate}");
        Console.WriteLine($"Time of Event: {_eventTime}");
        Console.WriteLine($"Address: {_eventAddress}");
    }

}