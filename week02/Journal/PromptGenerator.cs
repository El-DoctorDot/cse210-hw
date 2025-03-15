// Purpose: This file contains the PromptGenerator class definition. The PromptGenerator class is used to generate a random prompt from a list of prompts. 
// The list of prompts is stored in the _prompts list. The GetRandomPrompt method is used to get a random prompt from the list of prompts. The Random class is used to generate a random index to select a prompt from the list of prompts.

using System;
public class PromptGenerator // PromptGenerator class definition.
{
    public List<string> _prompts; // Declaration of the prompts list.

    public PromptGenerator() 
    {
        _prompts = new List<string>();
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What is my favorite animal?");
        _prompts.Add("If I had a power, what kind of power would I choose ?");
        _prompts.Add("What kind of hobby could I learn?");
        _prompts.Add("What is my favorite season?");
        _prompts.Add("What is my favorite holiday and Why?");
    }

    
    public string GetRandomPrompt() // Method to get a random prompt.
    {
       Random random = new Random(); // Creates a new Random object.
       int index = random.Next(_prompts.Count); // Generates a random index.
       return _prompts[index]; // Returns the prompt at the random index.
    }
}