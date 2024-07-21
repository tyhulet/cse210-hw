using System.Security.Cryptography.X509Certificates;

public class RunningActvity : Actvitys
{
    private double _milesRan;

    public RunningActvity(string date, int minuntes, double milesRan) : base(date, minuntes)
    {
        _milesRan = milesRan;
    }

    public override double GetDistance()
    {
        return _milesRan;
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
        Console.WriteLine($"{_date}, Running ({_minuntes} mins): Distance {GetDistance()} Miles, Speed {GetSpeed()} MPH, Pace {GetPace()} min per mile");
    }
}