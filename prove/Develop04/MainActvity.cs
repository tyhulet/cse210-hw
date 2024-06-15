public class MainActvity
{
    protected string _name;

    protected string _actvityDescription;

    protected int _duration;

    public void StartingActvity()
    {
        _name = "";
        _actvityDescription = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"For this actvity {_actvityDescription}");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Great Job you completed the actvity!!");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void timer(int seconds)
    {

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

