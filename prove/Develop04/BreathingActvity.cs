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
        Console.WriteLine("Breathe In");
        CountdownEvent(6);

        Console.WriteLine("Breathe Out");
        CountdownEvent(6);


        DisplayEndingMessage();
    }
}