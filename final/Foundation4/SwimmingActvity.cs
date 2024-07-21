using System.Data;

public class SwimmingActvity : Actvitys
{
    private int _swimmingLaps;

    public SwimmingActvity(string date, int minuntes, int swimmingLaps) : base(date, minuntes)
    {
        _swimmingLaps = swimmingLaps;
    }

    public override double GetDistance()
    {
        return _swimmingLaps * 50 / 1000 * .62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _minuntes * 60;
    }

    public override double GetPace()
    {
        return Math.Round(_minuntes / GetDistance(), 2);
    }

    public override void ActvitySummary()
    {
        Console.WriteLine($"{_date}, Swimming ({_minuntes} mins): Distance {GetDistance()} Miles, Speed {GetSpeed()} MPH, Pace {GetPace()} min per mile");
    }
}