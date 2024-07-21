public class Actvitys
{
    private string _date;
    protected int _minuntes;

    public Actvitys(string date, int minuntes)
    {
        _date = date;
        _minuntes = minuntes;
    }

    public virtual double GetDistance()
    {
        return GetDistance();
    }

    public virtual double GetSpeed()
    {
        return GetSpeed();
    }

    public virtual double GetPace()
    {
        return GetPace();
    }

    public virtual string ActvitySummary()
    {
        return ActvitySummary();
    }
}