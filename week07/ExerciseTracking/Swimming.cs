public class Swimming : Activity
{
    private double _laps;

    public Swimming(DateTime date, int minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return (_laps * 50.0) / 1000.0;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / _minutes) * 60.0;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return (distance / _minutes);
    }
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutes}min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km ";
    }


}