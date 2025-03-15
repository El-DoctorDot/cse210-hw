// Purpose: Entry class definition. I added a other information in the journal entry.
// The Entry class represents a journal entry and contains properties for the date, prompt text, entry text, and emotion.
using System;
using System.IO.Compression;
public class Entry // Entry class definition.
{
    public string _date; 
    public string _promptText; 
    public string _entryText; 
    public string _emotion; 
    public string _weather;
    public void Display() // Display method definition.
    {
       Console.WriteLine($"Date: {_date} - Prompt:{_promptText}"); // Displays the date and prompt text.
       
       Console.WriteLine(_entryText); // Displays the entry text.

       Console.WriteLine($"Emotion: {_emotion}"); // Displays the emotion.

         Console.WriteLine($"Weather: {_weather}"); // Displays the weather.
    }
}