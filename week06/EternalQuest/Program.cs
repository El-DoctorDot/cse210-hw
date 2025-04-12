// This is a simple console application that allows users to manage their goals.
// I added Gamification, implementing a level system, where the user levels up when reaching a minimum score, with progress notifications and bonuses. 
//Also, goal diversity where new types of goals were added, including progressive goals (for big goals, like running a marathon) and negative goals (for losing points with bad habits).

using System;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "goals.txt";
        
        GoalManager.Instance.LoadGoals(filePath);
        
        ShowMenu();

        bool running = true;
        while (running)
        {
            Console.Write("\nChoose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddGoal();
                    break;
                case "2":
                    RecordGoalEvent();
                    break;
                case "3":
                    GoalManager.Instance.ShowGoals();
                    break;
                case "4":
                    GoalManager.Instance.ShowProgress();
                    break;
                case "5":
                    SaveGoalsAndExit(filePath);
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Add new goal");
        Console.WriteLine("2. Register event for a goal");
        Console.WriteLine("3. View all goals");
        Console.WriteLine("4. Show progress");
        Console.WriteLine("5. Save and exit");
    }

    static void AddGoal()
    {
        Console.Write("Enter the short name of the goal: ");
        string shortName = Console.ReadLine();
        
        Console.Write("Enter the goal description:");
        string description = Console.ReadLine();
        
        Console.Write("Enter points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("\nchoose the type of goal");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Negative goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Eternal goal");
        Console.WriteLine("5.Progressive goal");

        int choice = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (choice)
        {
            case 1:
                newGoal = new SimpleGoal(shortName, description, points);
                break;
            case 2:
                newGoal = new NegativeGoal(shortName, description, points);
                break;
            case 3:
                Console.Write("Enter the number of steps ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus upon completion: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new CheckListGoal(shortName, description, points, target, bonus);
                break;
            case 4:
                newGoal = new EternalGoal(shortName, description, points);
                break;
            case 5:
                Console.Write("Enter points per step: ");
                int pointsPerStep = int.Parse(Console.ReadLine());
                Console.Write("Enter the total number of steps: ");
                int goalAmount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus upon completing the goal:");
                int rewardBonus = int.Parse(Console.ReadLine());
                newGoal = new ProgressiveGoal(shortName, description, pointsPerStep, goalAmount, rewardBonus);
                break;
            default:
                Console.WriteLine("Invalid meta type.");
                return;
        }

        GoalManager.Instance.AddGoal(newGoal);
        Console.WriteLine("Goal added successfully!");
    }

    static void RecordGoalEvent()
    {
        Console.Write("Enter the target number to register the event: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        GoalManager.Instance.RecordEvent(goalIndex);
    }

    static void SaveGoalsAndExit(string filePath)
    {
        GoalManager.Instance.SaveGoals(filePath);
        Console.WriteLine("Goals saved successfully! Exiting...");
    }
}