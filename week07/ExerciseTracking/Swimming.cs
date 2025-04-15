using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(int laps, int time) : base(time)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; 
    }
    public override double GetSpeed()
    {
        return (GetDistance() /  GetTime()) * 60; 
    }
    public override double GetPace()
    {
        return GetTime() / GetDistance(); 
    }
}