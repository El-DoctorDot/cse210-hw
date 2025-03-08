//The program asks the user to enter their final grade (score) and, based on this value, determines a letter corresponding to their average (A, B, C, D or F). 
// If the grade is greater than or equal to 70, the program also assigns a "+" or "-" sign to the letter, depending on the last digit of the grade. 
// For example, if the grade is 85, the program will return 'B+' and, if it is 68, it will return 'D'."

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is the percentage of your grade?");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        int percentage = number;
        
        string letter = "";
        string sign = "";

    
            if (percentage >= 90)
            {
                letter = "A";
            }
            else if (percentage >= 80)
            {
                letter = "B";
            }
            else if (percentage >= 70)
            {
                letter = "C";
            }
            else if (percentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

             int lastDigit = percentage % 10; 
            if (lastDigit >= 7 && letter != "F")  
            {
                sign = "+";
            }
            else if (lastDigit < 3 && letter != "F")  
            {
                sign = "-";
            }

            Console.WriteLine($"Your grade is {letter}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class");
        }
        else
        {
            Console.WriteLine("You failed. That's okay! I know you'll do better next time.");
        }
    }
}