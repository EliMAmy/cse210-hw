public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    public override double GetDistance() => _distance;


    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60.0;
    }

    public override double GetPace()
    {
        double distance = GetDistance();

        return _minutes / distance;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes}min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km ";
    }


}