using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) 
        : base(shortName, description, points) 
    {
    }

    public override void RecordEvent() 
    {
        Console.WriteLine($"{GetShortName()} event recorded. You earned {GetPoints()} points!");
        GoalManager.Instance.AddPoints(GetPoints()); 
    }

    public override bool IsComplete() 
    {
        return false; 
    }

    public override string GetStringRepresentation() 
    {
        return $"{base.GetStringRepresentation()} - Eternal Goal";
    }

    public override string GetDetailsString()
    {
        return $"{GetShortName()} - {GetDescription()} - {GetPoints()} points [∞]";
    }
}

