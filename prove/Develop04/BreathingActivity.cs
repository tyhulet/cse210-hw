public class BreathingActivity : MainActivity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _activityDescription = "will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunBreathing()
    {
        DisplayStartingMessage();
        SessionLength();
        SpinnerTimer(3);
        Breathing();
        DisplayEndingMessage();
    }

    public void Breathing()
    {
        DateTime startTime = DateTime.Now;
        DateTime furtureTime = startTime.AddSeconds(_sessionLengthInput);
        DateTime currentTime = DateTime.Now;
        while (currentTime < furtureTime)
        {
            Console.WriteLine("Breath In");
            CountdownEvent(5);
            Console.WriteLine("Hold in....");
            CountdownEvent(2);
            Thread.Sleep(500);
            Console.WriteLine("Breath out");
            CountdownEvent(5);
            Thread.Sleep(500);


            currentTime = DateTime.Now;
        }
    }
}