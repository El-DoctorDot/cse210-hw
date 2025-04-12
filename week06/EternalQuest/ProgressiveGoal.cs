using System;

public class ProgressiveGoal : Goal
{
    private int _currentProgress;
    private int _goalAmount;
    private int _rewardBonus;

    public ProgressiveGoal(string shortName, string description, int pointsPerStep, int goalAmount, int rewardBonus)
        : base(shortName, description, pointsPerStep)
    {
        _currentProgress = 0;
        _goalAmount = goalAmount;
        _rewardBonus = rewardBonus;
    }

    public override void RecordEvent()
    {
        if (_currentProgress < _goalAmount)
        {
            _currentProgress++;
            Console.WriteLine($"Progress recorded for {GetShortName()}: {_currentProgress}/{_goalAmount}");

            GoalManager.Instance.AddPoints(GetPoints());

            if (_currentProgress == _goalAmount)
            {
                Console.WriteLine($"Goal achieved! Bonus of {_rewardBonus} points!");
                GoalManager.Instance.AddPoints(_rewardBonus);
            }
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }

    public override bool IsComplete()
    {
        return _currentProgress >= _goalAmount;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Progress: {_currentProgress}/{_goalAmount}";
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},{_goalAmount},{_rewardBonus} - Progress: {_currentProgress}/{_goalAmount} - Bonus: {_rewardBonus}";
    }
}
