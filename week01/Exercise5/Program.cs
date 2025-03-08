using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(squaredNumber, userName);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");

    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult( int square, string name)
    {
        Console.WriteLine($" {name}, the square of your number is {square}");
    }
   
}   
