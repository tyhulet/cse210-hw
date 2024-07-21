using System.Data;

public class CyclingActvity : Actvitys
{
    private double _averageSpeed;

    public CyclingActvity(string date, int minuntes, double avereageSpeed) : base(date, minuntes)
    {
        _averageSpeed = avereageSpeed;
    }

    public override string ActvitySummary()
    {
        return ActvitySummary();
    }
    public override double GetDistance()
    {

        return 0;
    }

    public override double GetSpeed()
    {
        return _averageSpeed;
    }

    public override double GetPace()
    {
        return GetPace();
    }
}