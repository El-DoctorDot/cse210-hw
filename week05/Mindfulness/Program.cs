// Mindfulness Program
// This program provides a menu-driven interface for various mindfulness activities. I added a new activity called GratitudeActivity to help users focus on positive aspects of their lives.

using System;

class Program
{
    static void Main(string[] args)
    {
         int choice = 0;

        while (choice != 5)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start gratitude activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string input = Console.ReadLine();
            bool isValid = int.TryParse(input, out choice);

            if (!isValid || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                Thread.Sleep(1000);
                continue;
            }

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity(
                        "Breathing",
                        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
                    );
                    breathing.Run();
                    break;

                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity(
                        "Reflecting",
                        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                    );
                    reflecting.Run();
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity(
                        "Listing",
                        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                    );
                    listing.Run();
                    break;

                case 4:
                    GratitudeActivity gratitude = new GratitudeActivity(
                        "Gratitude",
                        "This activity will help you focus on the positive by listing things you're grateful for. Gratitude helps improve your overall mindset."
                    );
                    gratitude.Run();
                    break;

                case 5:
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}