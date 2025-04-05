using System;

public class GratitudeActivity : Activity // Inherits from the Activity class
{
    public GratitudeActivity(string name, string description) : base(name, description) {}

    public void Run() 
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("List as many things as you are grateful for.");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                count++;
            }
        }

        Console.WriteLine($"\nYou listed {count} things you're grateful for. Great job!");
        DisplayEndingMessage();
    }
}
