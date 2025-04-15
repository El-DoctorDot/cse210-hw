using System;

public class Cycling : Activity
{
    private double _distance;

    public Cycling(double distance, int time) : base(time)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / GetTime()) * 60;

    }
    public override double GetPace()
    {
        return GetTime() / _distance;
    }
}