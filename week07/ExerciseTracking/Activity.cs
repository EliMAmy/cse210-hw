
public abstract class Activity
{
    protected DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();// km/h
    public abstract double GetPace();// min/km

    public abstract string GetSummary();
    

}