using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetShortName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"{_shortName} - {_description} - {_points} points";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{this.GetType().Name}:{_shortName},{_description},{_points}";
    }
     public static Goal CreateFromString(string data)
    {
        var parts = data.Split(':');
        if (parts.Length < 2) return null;

        var typeName = parts[0];
        var details = parts[1].Split(',');

        if (typeName == "SimpleGoal")
        {
            return new SimpleGoal(details[0], details[1], int.Parse(details[2]));
        }
        else if (typeName == "NegativeGoal")
        {
            return new NegativeGoal(details[0], details[1], int.Parse(details[2]));
        }
        else if (typeName == "CheckListGoal")
        {
            return CheckListGoal.CreateFromData(details);
        }
        else if (typeName == "EternalGoal")
        {
            return new EternalGoal(details[0], details[1], int.Parse(details[2]));
        }
        else if (typeName == "ProgressiveGoal")
        {
        
            int pointsPerStep = int.Parse(details[2]);
            int goalAmount = int.Parse(details[3]);
            int rewardBonus = int.Parse(details[4]);
            return new ProgressiveGoal(details[0], details[1], pointsPerStep, goalAmount, rewardBonus);
        }

        return null;
    }

}
