using System;

public class BreathingActivity : Activity // Inherits from the Activity class
{
    private int _BreatheCount;
    private int _BreatheInTime;
    private int _BreatheOutTime;

    public BreathingActivity(string name, string description) : base(name, description) // Constructor to initialize the activity with a name and description
    
    {
        _BreatheCount = 0;
        _BreatheInTime = 4; 
        _BreatheOutTime = 4; 
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime) // Loop until the end time is reached 
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(_BreatheInTime);
            _BreatheCount++;

            Console.WriteLine("Breathe out...");
            Countdown(_BreatheOutTime);
            _BreatheCount++;
        }

        Console.WriteLine($"\nWell done!! You have completed {_BreatheCount} breaths.");
        DisplayEndingMessage();
    }
}
