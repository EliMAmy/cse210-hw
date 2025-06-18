using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        DateTime today = DateTime.Today;
        Cycling cycling = new Cycling(today, 45, 25);
        Running run = new Running(today, 60, 60);
        Swimming swim = new Swimming(today, 40, 30);

        _activities.Add(cycling);
        _activities.Add(run);
        _activities.Add(swim);

        foreach (Activity s in _activities)
        {
            Console.WriteLine(s.GetSummary());
        }


    }
}