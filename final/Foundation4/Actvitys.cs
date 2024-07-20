public class Actvitys
{
    private string _date;
    private int _minuntes;

    public Actvitys(string date, int minuntes)
    {
        _date = date;
        _minuntes = minuntes;
    }


    public abstract string ActvitySummary()
    {

    }
    public abstract double getDistance()
    {

    }

    public abstract double getSpeed()
    {

    }

    public abstract double getPace()
    {

    }
}