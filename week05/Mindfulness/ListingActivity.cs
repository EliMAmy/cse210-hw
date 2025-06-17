using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts= new List<string>();

    private List<string> list = new List<string>();

    public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _count = count;
    }
    public List<string> GetListPrompt()
    {
        return _prompts;
    }
    public void SetPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    public void Run()
    {
        Console.WriteLine("You may begin in: ");
        ShowCountDown();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> list = new List<string>();
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            list.Add(item);
        }

    int _count = list.Count();
    Console.WriteLine($"You listed {_count} items");

    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(5);
        string ramdom = _prompts[index];
        return ramdom;
    }

    public List<string> GetListFromUser()
    {
        return list;
    } 
}