// Purpose: Contains the Journal class, which represents a journal that stores entries and provides methods to add, display, save, and load entries.
// The Journal class contains a list of Entry objects to store the journal entries. The AddEntry method adds a new entry to the list, the DisplayAll method displays all the entries in the list, the SaveToFile method saves the entries to a file, and the LoadFromFile method loads entries from a file.
using System.Collections.Generic;
using System;
using System.IO;
public class Journal
{
    // Declaration of a list that will store the journal entries.
    public List<Entry> _entries;

    public Journal()
    {
        // Constructor that initializes the list of entries.
        _entries = new List<Entry>();
    }

    // Method to add a new entry to the list.
    public void AddEntry(Entry newEntry)
    {
       _entries.Add(newEntry); // Adds the new entry to the list.
    }

    // Method to display all the entries in the list.
    // Loops through the list and calls the Display method of each entry.
    public void DisplayAll()
    {
        foreach (Entry entry in _entries) // Loops through the list of entries.
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file) // Method to save the entries to a file.
    {
        using StreamWriter outputFile = new StreamWriter(file); // Creates a new StreamWriter object to write to the file.
        {
            foreach (Entry entry in _entries) // Loops through the list of entries.
            {
                outputFile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}, {entry._emotion}, {entry._weather}"); // Writes the entry data to the file.
            
            }
        }
    }
    public void LoadFromFile(string file) // Method to load entries from a file.
    {
        string[] lines = System.IO.File.ReadAllLines(file); // Reads all lines from the file.
        foreach (string line in lines) // Loops through the lines.
        {
            string[] parts = line.Split(','); // Splits the line into parts using the comma as a delimiter.

            Entry newEntry = new Entry(); // Creates a new Entry object.
            newEntry._date = parts[0]; // Assigns the parts to the entry properties.
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            newEntry._emotion = parts[3];
            newEntry._weather = parts[4];

            _entries.Add(newEntry); // Adds the new entry to the list.
        }

  
    }
}

    