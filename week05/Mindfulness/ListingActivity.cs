using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _Count;
    private List<string> _Prompts = new List<string>() // List of prompts for the user to respond to 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {
        _Count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage(); 

        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt(); 

        Console.Write("You may begin in: ");
        Countdown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                _Count++;
            }
        }

        Console.WriteLine($"\nYou listed {_Count} items.");
        DisplayEndingMessage(); 
    }

    public void GetRandomPrompt() // Selects a random prompt from the list of prompts
    {
        Random random = new Random();
        int index = random.Next(_Prompts.Count);
        Console.WriteLine($"\n--- {_Prompts[index]} ---\n");
    }

    public List<string> GetListForUser()
    {
        return _Prompts;
    }
}

