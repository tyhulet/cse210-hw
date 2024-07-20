public class Receptions : Events
{
    private string _emailRSVP;

    public Receptions(string eventTitle, string eventDesctiption, string eventDate, string eventTime, string eventAddress, string emailRSVP)
    : base(eventTitle, eventDesctiption, eventDate, eventTime, eventAddress)
    {
        _emailRSVP = emailRSVP;
    }

    public void DisplayRSVP()
    {
        Console.WriteLine($"Email Rsvp: {_emailRSVP}");
    }
}