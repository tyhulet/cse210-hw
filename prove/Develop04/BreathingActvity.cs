public class BreathingActivity : MainActvity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _activityDescription = "will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunBreathing()
    {

        DisplayStartingMessage();
        Console.WriteLine("We'll begin Shortly...");
        SpinnerTimer(5);
        Thread.Sleep(500);
        Console.WriteLine("Let's Begin");
        Thread.Sleep(1500);
        Console.WriteLine("Breathe In");
        CountdownEvent(5);

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
    }
}