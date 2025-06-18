public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return (_speed * _minutes) / 60;
    }

    public override double GetSpeed() => _speed;

    public override double GetPace()
    {
        double distance = GetDistance();

        return _minutes / distance;
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_minutes}min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km ";
    }

}