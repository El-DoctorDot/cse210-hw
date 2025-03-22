// Purpose: Main program for the Scripture Memorizer program.
// The program displays a random scripture and hides a random number of words until the user types 'quit'. And the program also works with a library of scriptures instead of a single one. It randomly chooses scriptures to present to the user.
using System;

class Program
{
    static void Main(string[] args)
    {
       
        List<Scripture> scriptures = new List<Scripture> // List of scriptures
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life."),
            new Scripture(new Reference("John", 14, 6), "Jesus said to him, 'I am the way, and the truth, and the life. No one comes to the Father except through me.'"),
            new Scripture(new Reference("Romans", 3, 23), "For all have sinned and fall short of the glory of God."),
            new Scripture(new Reference("Romans", 6, 23), "For the wages of sin is death, but the free gift of God is eternal life in Christ Jesus our Lord."),
            new Scripture(new Reference("Doctrine and Covenants", 35, 8), "For I am God, and mine arm is not shortened; and I will show miracles, signs, and wonders, unto all those who believe on my name.")
        };

        // Randomly select a scripture from the list
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Display the scripture and hide words until the user types 'quit'
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear(); 
            Console.WriteLine(scripture.GetDisplayText()); 
            Console.Write("Press Enter to hide the words or type 'quit' to exit: "); 

            string input = Console.ReadLine();
            if (input.ToLower() == "quit") // Check if the user typed 'quit'
            {
                break;  // Exit the loop
            }

            scripture.HideRandomWords(3); 
        }

        Console.Clear(); 
        Console.WriteLine("Goodbye!"); 
    }
}