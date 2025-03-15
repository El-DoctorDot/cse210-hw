// Purpose: This file contains the main program that runs the Journal application. And I added the option to write the user's emotion and the weather, this information is found in the journal entry.
// It allows the user to write, display, save, and load entries.
using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args) // Main method definition.
    {
         Console.WriteLine("Welcome to the Journal!");

        Journal journal = new Journal(); // Creates a new Journal object.
        string choice;

        do // Do-while loop to display the menu and get user input.
        {
            Console.WriteLine("Please Select an Option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            Console.WriteLine("");// Blank

            choice = Console.ReadLine();

            if (choice == "1") // If the user selects option 1.
            {
                PromptGenerator promptGenerator = new PromptGenerator(); // Creates a new PromptGenerator object.
                string randomPrompt = promptGenerator.GetRandomPrompt(); // Gets a random prompt.
                Console.WriteLine("");// Blank 
                Console.WriteLine(randomPrompt); // Displays the random prompt.
                string answer = Console.ReadLine(); // Gets the user's answer to the prompt.

                Console.WriteLine("How are you feeling today? ");
                string emotion = Console.ReadLine(); // Gets the user's emotion.

                Console.WriteLine("What's the weather like?");
                String weather = Console.ReadLine(); // Gets the user's weather.

                DateTime theCurrentTime = DateTime.Now; // Gets the current date and time.
                string dateText = theCurrentTime.ToShortDateString(); // Converts the date to a string.

                Entry entry = new Entry // Creates a new Entry object with the user's input.
                {
                    _date = dateText,
                    _promptText = randomPrompt,
                    _entryText = answer,
                    _emotion = emotion,
                    _weather = weather
                };

                journal.AddEntry(entry); // Adds the entry to the journal.
                Console.WriteLine("");// Blank
            }
            else if (choice == "2") // If the user selects option 2.

            {   Console.WriteLine("");// Blank
                journal.DisplayAll(); // Calls the DisplayAll method to display all the entries.
            }   
            else if (choice == "3") // If the user selects option 3.

            {   Console.WriteLine("");// Blank
                Console.Write("Enter the file name to save: ");
                string file = Console.ReadLine(); // Gets the file name from the user.
                journal.SaveToFile(file); // Calls the SaveToFile method to save the entries to the file.
            } 

            else if (choice == "4") // If the user selects option 4.

            {   Console.WriteLine("");// Blank
                Console.Write("Enter the file name to load (Add .txt or .csv to the end of the file name): ");
                string file = Console.ReadLine(); // Gets the file name from the user.
                journal.LoadFromFile(file); // Calls the LoadFromFile method to load the entries from the file.
                Console.WriteLine("");// Blank
            }
            else if (choice == "5") // If the user selects option 5.
            {
                break; // Exits the loop.
            }
            else
            {   Console.WriteLine("");// Blank
                Console.WriteLine("Invalid Option");
            }

        } while (choice != "5"); // Loop continues until the user selects option 5.

    }  
   
}