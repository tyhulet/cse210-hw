using System.Security.Cryptography.X509Certificates;

public class RunniingActvity : Actvitys
{
    private double _milesRan;

    public RunniingActvity(string date, int minuntes, double milesRan) : base(date, minuntes)
    {
        _milesRan = milesRan;
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
        return 0;
    }

    public override double GetPace()
    {
        return 0;
    }
}