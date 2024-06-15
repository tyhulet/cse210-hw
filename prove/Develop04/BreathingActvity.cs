public class BreathingActivity : MainActvity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _actvityDescription = "you will be walked through a breathing excersie.";
    }

    public void RunBreathing()
    {

        DisplayStartingMessage();
        Console.WriteLine("Let's Begain");
        Thread.Sleep(1500);
        Console.WriteLine("Breathe In");
        CountdownEvent(6);

        Console.WriteLine("Hold it for 2 secounds");
        Thread.Sleep(2000);

        Console.WriteLine("Now....");
        Thread.Sleep(1000);
        Console.WriteLine("Breathe Out");
        CountdownEvent(5);

        Console.WriteLine("Let's go again");
        Thread.Sleep(1000);
        Console.WriteLine("Breathe In");
        CountdownEvent(5);

        Console.WriteLine("Hold it for 2 secounds");
        Thread.Sleep(2000);

        Console.WriteLine("Now....");
        Thread.Sleep(1000);
        Console.WriteLine("Breathe Out");
        CountdownEvent(5);


        DisplayEndingMessage();
        Console.WriteLine("Returning you back to the menu.");
    }
}