using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, int points, int target, int bonus) 
        : base(shortName, description, points) 
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent() 
    {
        if (_amountCompleted < _target) 
        {
            _amountCompleted++;
            Console.WriteLine($"Progress made on '{GetShortName()}': {_amountCompleted}/{_target}.");

            GoalManager.Instance.AddPoints(GetPoints());

            
            if (_amountCompleted == _target) 
            {
                Console.WriteLine($"🎉 Checklist '{GetShortName()}' completed! Bonus {_bonus} points awarded!");
                GoalManager.Instance.AddPoints(_bonus);
            }
        }
        else
        {
            Console.WriteLine($"Checklist '{GetShortName()}' already completed.");
        }
    }

    public override bool IsComplete() 
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} — Progress: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation() 
    {
        return $"{this.GetType().Name}:{GetShortName()},{GetDescription()},{GetPoints()},{_target},{_bonus},{_amountCompleted}";
    }

    public static CheckListGoal CreateFromData(string[] details)
    {
        string name = details[0];
        string desc = details[1];
        int points = int.Parse(details[2]);
        int target = int.Parse(details[3]);
        int bonus = int.Parse(details[4]);
        int amountCompleted = int.Parse(details[5]);

        var goal = new CheckListGoal(name, desc, points, target, bonus);
        goal._amountCompleted = amountCompleted;
        return goal;
    }
}
