using System;

public class NegativeGoal : Goal
{
    public bool IsCompleted { get; private set; }

    public NegativeGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        IsCompleted = false;
    }

    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            Console.WriteLine($"Goal '{GetShortName()}' completed! You lost {GetPoints()} points.");
        }
        else
        {
            Console.WriteLine("This negative goal was already triggered.");
        }
    }

    public override bool IsComplete()
    {
        return IsCompleted;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + (IsCompleted ? " [X]" : " [ ]");
    }
}


