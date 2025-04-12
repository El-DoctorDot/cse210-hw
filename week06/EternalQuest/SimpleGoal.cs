using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) 
        : base(shortName, description, points) 
    {
        _isComplete = false;
    }
    public override void RecordEvent() 
    {
        if (!_isComplete) 
        {
            _isComplete = true;
            Console.WriteLine($"You've completed the goal and earned {GetPoints()} points!");
        }
        else
        {
            Console.WriteLine("Goal already completed. No additional points earned.");
        }
    }
    public override bool IsComplete() 
    {
        return _isComplete;
    }
    public override string GetStringRepresentation() 
    {
        return $"{base.GetStringRepresentation()} - Completed: {_isComplete}";
    }
     public override string GetDetailsString()
    {
        return base.GetDetailsString() + (_isComplete ? " [X]" : " [ ]");
    }
}
