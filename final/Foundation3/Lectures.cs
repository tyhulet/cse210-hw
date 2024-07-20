public class Lectures : Events
{
    private string _speaker;

    private int _maxCapicty;

    public Lectures(string eventTitle, string eventDesctiption, string eventDate, string eventTime, string eventAddress, string speaker, int maxCapicty)
    : base(eventTitle, eventDesctiption, eventDate, eventTime, eventAddress)
    {
        _speaker = speaker;
        _maxCapicty = maxCapicty;
    }

    public void DisplayLectures()
    {
        Console.WriteLine($"Speaker: {_speaker}, Capicty {_maxCapicty}");
    }

}