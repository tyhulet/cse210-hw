using System.Net;

public class Entry
{
    public string entryText;
    public string Date;
    public string Prompt;

    public Entry(string prompt, string entries, string date)
    {
        Prompt = prompt;
        entryText = entries;
        Date = date;
    }
}