using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

public class ListingActvity : MainActvity
{
    protected List<string> _listingPrompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heros?"
    };


    public ListingActvity()
    {
        _name = "Listing Actvity";
        _actvityDescription = "will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    }

    public void RunListingActvity()
    {
        DisplayStartingMessage();
        RandomListingPrompt();
        SessionLength();
        ListFromUser();
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public void RandomListingPrompt()
    {
        Console.WriteLine("Anwser as many times as you can to the flowing prompt: ");
        Console.WriteLine();
        Random random = new Random();
        int promptindex = random.Next(_listingPrompts.Count());
        Console.WriteLine(_listingPrompts[promptindex]);
        Console.WriteLine();
    }

    public void ListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime furtureTime = startTime.AddSeconds(_sessionLengthInput);
        DateTime currentTime = DateTime.Now;
        int count = 0;
        while (currentTime < furtureTime)
        {
            Console.Write(" -");
            Console.ReadLine();
            count += 1;
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items.");
        SpinnerTimer(5);
    }



}