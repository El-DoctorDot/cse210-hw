using System;


public class GoalManager
{
    private static GoalManager _instance;
    public static GoalManager Instance => _instance ??= new GoalManager();

    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;
    private int _nextLevelThreshold = 1000;
    private HashSet<string> _unlockedAchievements = new HashSet<string>();

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine(" Invalid goal.");
            return;
        }

        _goals[index].RecordEvent();

        if (_goals[index] is NegativeGoal)
        {
            RemovePoints(_goals[index].GetPoints());
        }
        else
        {
            AddPoints(_goals[index].GetPoints());
        }

        CheckAchievements();
    }

    public void AddPoints(int points)
    {
        _score += points;
        while (_score >= _nextLevelThreshold)
        {
            _level++;
            _nextLevelThreshold += 1000;
            Console.WriteLine($" Congratulations! You have moved up to level {_level}!");
        }
    }

    public void RemovePoints(int points)
    {
        _score -= points;
        if (_score < 0) _score = 0;
    }

    public void ShowGoals()
    {
        Console.WriteLine(" Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {_goals[i].GetDetailsString()}");
        }
    }

    public void ShowProgress()
    {
        int completedCount = _goals.Count(g => g.IsComplete());
        Console.WriteLine($"\n Progress report:");
        Console.WriteLine($"- Score: {_score}");
        Console.WriteLine($"- Level: {_level}");
        Console.WriteLine($"- Goals completed: {completedCount}/{_goals.Count}");
        Console.WriteLine($"- Achievements: {string.Join(", ", _unlockedAchievements)}\n");
    }

    private void CheckAchievements()
    {
        int completedCount = _goals.Count(g => g.IsComplete());

        if (completedCount >= 5 && !_unlockedAchievements.Contains("Conqueror"))
        {
            Console.WriteLine(" Achievement unlocked: Conqueror! (+500 pontos)");
            AddPoints(500);
            _unlockedAchievements.Add("Conqueror");
        }

        if (_score >= 3000 && !_unlockedAchievements.Contains("Points Millionaire"))
        {
            Console.WriteLine("Achievement Unlocked: Points Millionaire!");
            _unlockedAchievements.Add("Points Millionaire");
        }
    }
    public void SaveGoals(string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals(string filePath)
    {
        if (!File.Exists(filePath)) return;

        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var goal = Goal.CreateFromString(line);
            if (goal != null)
            {
                _goals.Add(goal);
            }
        }
    }


}
