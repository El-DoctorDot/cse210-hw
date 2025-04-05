using System;

public class Activity // Base class for all activities
{
    private string _Name;
    private string _Description;
    private int _Duration;

    public Activity(string name, string description) // Constructor to initialize the activity with a name and description
    {
        _Name = name;
        _Description = description;
        _Duration = 0;
    }
    public void DisplayStartingMessage() // Displays the starting message for the activity
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_Name} activity.");
        Console.WriteLine(_Description);
        
        Console.Write("How long, in seconds, would you like for your session? ");
        _Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); 
    }

   public void DisplayEndingMessage() // Displays the ending message for the activity
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_Name} activity for {_Duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner( int seconds) // Displays a spinner animation for the specified number of seconds
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b/");
            Thread.Sleep(1000);
            Console.Write("\b-");
            Thread.Sleep(1000);
            Console.Write("\b\\");
            Thread.Sleep(1000);
        }
    }
    public void Countdown(int seconds) // Displays a countdown from the specified number of seconds
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public int GetDuration()
    {
        return _Duration;
    }
}