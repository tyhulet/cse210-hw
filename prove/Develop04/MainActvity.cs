public class MainActvity
{
    protected string _name;

    protected string _activityDescription;

    protected int _duration;

    protected int _sessionLengthInput;

    public void StartingActvity()
    {
        _name = "";
        _activityDescription = "";
        _duration = 10;
        _sessionLengthInput = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"This actvity {_activityDescription}");
        Thread.Sleep(3000);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Great Job you completed the actvity!! ");
        Console.WriteLine($"Returning you to the Actvity options shortly. ");
        Thread.Sleep(5000);
        Console.Clear();
    }

    public void SpinnerTimer(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            seconds--;
            Console.Write("\b \b");
        }
    }

    public void SessionLength()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _sessionLengthInput = int.Parse(Console.ReadLine());
    }

    public void CountdownEvent(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            seconds--;
            Console.Write("\b \b");
        }

    }

}

