using System.Data;

public class CyclingActvity : Actvitys
{
    private double _averageSpeed;

    public CyclingActvity(string date, int minuntes, double avereageSpeed) : base(date, minuntes)
    {
        _averageSpeed = avereageSpeed;
    }

    public override double GetDistance()
    {

        return Math.Round(_averageSpeed / _minuntes * 60, 2);
    }

    public override double GetSpeed()
    {
        return _averageSpeed;
    }

    public override double GetPace()
    {
        return Math.Round(_minuntes / GetDistance(), 2);
    }

    public override void ActvitySummary()
    {
        Console.WriteLine($"{_date}, Cycling ({_minuntes} mins): Distance {GetDistance()} Miles, Speed {GetSpeed()} MPH, Pace {GetPace()} min per mile");
    }
}