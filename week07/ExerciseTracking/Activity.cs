using System;

public abstract class Activity
{
    private DateTime _date = DateTime.Now;
    private int _time = 0;

    public Activity(int time)
    {
        _date = DateTime.Now;
        _time = time;
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public int GetTime()
    {
        return _time;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date: dd MMM yyyy} {GetType().Name} ({_time} min): Distance {GetDistance()} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}