using System.Net;

public class Entry
{
    public string Response;
    public string Date;
    public string Prompt;

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}