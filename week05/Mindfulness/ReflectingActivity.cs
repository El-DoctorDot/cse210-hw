using System;

public class ReflectingActivity : Activity
{
    private List<string> _Prompts = new List<string>() // List of prompts for the user to reflect on 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you felt the Holy Ghost."
    };

    private List<string> _Questions = new List<string>() // List of questions for the user to reflect on their experience 
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:\n");
        GetRandomPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            GetRandomQuestion();
            ShowSpinner(5); 
        }

        DisplayEndingMessage();
    }

    public void GetRandomPrompt() // Selects a random prompt from the list of prompts
    {
        Random random = new Random();
        int index = random.Next(_Prompts.Count);
        Console.WriteLine($"\n--- {_Prompts[index]} ---\n");
    }

    public void GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_Questions.Count);
        Console.WriteLine($"> {_Questions[index]}");
    }
}
