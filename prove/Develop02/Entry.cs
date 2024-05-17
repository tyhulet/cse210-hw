public class Entry
{
    public string _entryText;

    public string _date;

    public string _prompt;

    public void Display()
    {
        Console.WriteLine($"{_date} : {_prompt}");
        Console.WriteLine(_entryText);
    }
}